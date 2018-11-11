-- MySQL Script generated by MySQL Workbench
-- Fri Nov  2 12:50:19 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------
-- Schema new_schema1
-- -----------------------------------------------------
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`BankInfo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`BankInfo` (
  `Bank_Account_Nr` VARCHAR(20) NOT NULL,
  `HolderName` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`Bank_Account_Nr`))
ENGINE = InnoDB
COMMENT = 'This table store bank details of an account , because the purpose of having an account is to be able to do transaction and in that situation with need to access the bank info of account holder';


-- -----------------------------------------------------
-- Table `mydb`.`Account`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Account` (
  `Account_ID` INT NOT NULL AUTO_INCREMENT,
  `Email` VARCHAR(35) NOT NULL COMMENT 'The value of this columns is use to get into the website dashbord\n\nIndeed it is used as the username for a person.\n\nWe only save this for the admin in a group of the individuals',
  `Password` VARCHAR(30) NOT NULL,
  `Is_valid` ENUM('expire', 'valid') GENERATED ALWAYS AS ('valid') VIRTUAL COMMENT 'This column determine if an account still being valid or not.\n\nIt is requested that a visitor account should turn to expire upon check out\n',
  `Bank_Account_Nr` VARCHAR(20) NOT NULL,
  `Initial_Balance` DECIMAL(8) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Account_ID`),
  INDEX `FktoBankInfo_idx` (`Bank_Account_Nr` ASC),
  CONSTRAINT `FktoBankInfo`
    FOREIGN KEY (`Bank_Account_Nr`)
    REFERENCES `mydb`.`BankInfo` (`Bank_Account_Nr`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = 'This table is responisble to takes data about the group admin (in a group ticket) or the individual\'s event account. With this account the usera transactions can find to whom it relates.\n';


-- -----------------------------------------------------
-- Table `mydb`.`Group`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Group` (
  `User_Id` INT NOT NULL COMMENT 'It refers to user_id of user in Users table',
  `GroupID` INT NOT NULL COMMENT 'This column can be filled in order to show to which specific group as peson relates.\n',
  `Is_Admin` ENUM('no', 'yes') NOT NULL DEFAULT 'no' COMMENT 'This column is in the type of enum and determine if a person that belong to a group is the admin or regular participants.\n',
  PRIMARY KEY (`User_Id`),
  UNIQUE INDEX `User_Id_UNIQUE` (`User_Id` ASC))
ENGINE = InnoDB
COMMENT = 'This table is a subtype of user which determine the kind of person';


-- -----------------------------------------------------
-- Table `mydb`.`Users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Users` (
  `User_Id` INT GENERATED ALWAYS AS () VIRTUAL COMMENT 'This columns is use to preserve the ID for all the participant of the event.\n\nThen on ticket we will make it as barcode to be able to scan if he checked in or not\n\nAlso it will increase till the valid number of visitiors which is 25000 reached\n\nAlso it is the primary key of the whole table',
  `First_name` NVARCHAR(25) NOT NULL,
  `Last_name` VARCHAR(35) NOT NULL,
  `Account_Id` INT NOT NULL COMMENT 'This column determine the accountId in which that person belongs to.\n\nIndeed this is financial account where user need it do any transactions\n\nAlso it act as a foreign key to Account table\n\nBecause we assume that only persons with an account Id can do transaction to be able to follow its activities,For groups this fields is being the same with all the participants ',
  `Phone_Nr` INT NULL COMMENT 'It is possible for participants to not provide their phone number at the time of registeration\n',
  `Is_Group` ENUM('group', 'individual') NOT NULL DEFAULT 'individual' COMMENT 'This columns is used to determine if a person belongs to specific group of is registered as an individual\n',
  `Status` ENUM('checkd_in', 'checked_out', 'registered') NOT NULL DEFAULT 'registered' COMMENT 'This column person status:\nOn the creation, he would be only registered, when he entered to the event his status changed to CheckIn and when he leaves the event his status change to CheckedOut',
  `Group_User_Id` INT NOT NULL,
  PRIMARY KEY (`User_Id`),
  UNIQUE INDEX `UserID_UNIQUE` (`User_Id` ASC),
  INDEX `fkToAccount_idx` (`Account_Id` ASC),
  INDEX `fk_Users_Group1_idx` (`Group_User_Id` ASC),
  CONSTRAINT `fkToAccount`
    FOREIGN KEY (`Account_Id`)
    REFERENCES `mydb`.`Account` (`Account_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Users_Group1`
    FOREIGN KEY (`Group_User_Id`)
    REFERENCES `mydb`.`Group` (`User_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = 'This table is the place that we will store data about each individual. It is a supertype that has two subtype either a person belongs to a group or not.';


-- -----------------------------------------------------
-- Table `mydb`.`Individual`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Individual` (
  `User_id` INT NOT NULL,
  `IsVip` ENUM('no', 'yes') NOT NULL DEFAULT 'no' COMMENT 'Determine if a a person biught a VIP ticket or not\n',
  PRIMARY KEY (`User_id`),
  CONSTRAINT `user`
    FOREIGN KEY (`User_id`)
    REFERENCES `mydb`.`Users` (`User_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = 'If a person resereved his ticket in individual way then it should come here.';


-- -----------------------------------------------------
-- Table `mydb`.`Ticket`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Ticket` (
  `TicketID` INT GENERATED ALWAYS AS () VIRTUAL,
  `User_Id` INT NOT NULL,
  `Date_Of_Purchase` DATETIME GENERATED ALWAYS AS () VIRTUAL COMMENT 'We need to store the date of ticket purchase in order to check how long does it tooks from purchasing time to be able to cancel.',
  PRIMARY KEY (`TicketID`),
  INDEX `FkToUSeer_idx` (`User_Id` ASC),
  CONSTRAINT `FkToUSeer`
    FOREIGN KEY (`User_Id`)
    REFERENCES `mydb`.`Users` (`User_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = 'This table save date upon the visitors tickets\n';


-- -----------------------------------------------------
-- Table `mydb`.`Transactions`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Transactions` (
  `Transaction_Id` INT GENERATED ALWAYS AS () VIRTUAL,
  `Date` DATE GENERATED ALWAYS AS () VIRTUAL COMMENT 'We save date seperately from time because it might be possible to have different transaction in the same day but different time.\nThus it we use those together to query ',
  `Time` TIME NOT NULL,
  `Account_id` INT NOT NULL COMMENT 'Transaction should be perform if and only if it relates to on account and a user that does not access to an account can not do any transaction\n',
  `Amount` DECIMAL NOT NULL,
  `CurrentBalance` DECIMAL NOT NULL DEFAULT 0,
  `Type` ENUM('deposit', 'food', 'items', 'loan', 'registration', 'camp') NOT NULL,
  PRIMARY KEY (`Transaction_Id`),
  INDEX `FktoAccout_idx` (`Account_id` ASC),
  CONSTRAINT `FktoAccout`
    FOREIGN KEY (`Account_id`)
    REFERENCES `mydb`.`Account` (`Account_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = 'This entity will be use to save all the financial transactions records';


-- -----------------------------------------------------
-- Table `mydb`.`Articles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Articles` (
  `Article_Nr` INT GENERATED ALWAYS AS () VIRTUAL,
  `Type` ENUM('torch', 'usb', 'powerbank') NOT NULL,
  `Condition` ENUM('borken', 'working') NOT NULL DEFAULT 'working',
  PRIMARY KEY (`Article_Nr`))
ENGINE = InnoDB
COMMENT = 'This section is use to keep trck all of items that can lend to visitors to bee borrowed at loan stand.';


-- -----------------------------------------------------
-- Table `mydb`.`LoanEntity`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`LoanEntity` (
  `Article_Nr` INT NOT NULL,
  `TransactionID` INT NOT NULL,
  PRIMARY KEY (`Article_Nr`, `TransactionID`),
  INDEX `FKtoTransactions_idx` (`TransactionID` ASC),
  CONSTRAINT `FKtoTransactions`
    FOREIGN KEY (`TransactionID`)
    REFERENCES `mydb`.`Transactions` (`Transaction_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FKToArticles`
    FOREIGN KEY (`Article_Nr`)
    REFERENCES `mydb`.`Articles` (`Article_Nr`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = 'This entity is an intersection table that is use to keep track from those articles that were given to be borrowed by visitor and then to be check at the time of check-out and take back those given articles from user';


-- -----------------------------------------------------
-- Table `mydb`.`CampingSpots`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`CampingSpots` (
  `Spot_Nr` INT GENERATED ALWAYS AS () VIRTUAL,
  `Is_Reserved` ENUM('free', 'reserved') NOT NULL DEFAULT 'free' COMMENT 'This column is use to check if a camping spot being free to be offerred to new reservation or not.',
  `Is_Vip` ENUM('no', 'yes') NOT NULL DEFAULT 'no' COMMENT 'This columns is use to use to specify if a camping spot is designed for VIP persons or nir',
  PRIMARY KEY (`Spot_Nr`))
ENGINE = InnoDB
COMMENT = 'This table is responsible to store data of all camping spots within the Event campus\n';


-- -----------------------------------------------------
-- Table `mydb`.`CampingReservation`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`CampingReservation` (
  `Spot_Nr` INT NOT NULL,
  `Account_Nr` INT NOT NULL,
  `Is_paid` ENUM('no', 'yes') NOT NULL DEFAULT 'no' COMMENT 'This column is used to check if the user paid its reservation in advance or need to pay its fee at the time of checking at entrace to camping site',
  PRIMARY KEY (`Spot_Nr`, `Account_Nr`),
  INDEX `FkToAccount_idx` (`Account_Nr` ASC),
  CONSTRAINT `FkToCampingSpots`
    FOREIGN KEY (`Spot_Nr`)
    REFERENCES `mydb`.`CampingSpots` (`Spot_Nr`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FkToAccount`
    FOREIGN KEY (`Account_Nr`)
    REFERENCES `mydb`.`Account` (`Account_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = 'This is an intersection table to keep track of camping reservation\n';


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;