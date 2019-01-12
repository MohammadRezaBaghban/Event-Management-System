-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Generation Time: Jan 11, 2019 at 10:04 AM
-- Server version: 5.7.13-log
-- PHP Version: 5.6.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi400320`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `account_id` int(11) UNSIGNED NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `bank_act_nr` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `initial_balance` decimal(10,2) NOT NULL,
  `currentbal` decimal(10,2) NOT NULL,
  `is_valid` enum('yes','no') COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`account_id`, `email`, `phone`, `password`, `bank_act_nr`, `initial_balance`, `currentbal`, `is_valid`) VALUES
(1, 'ignore@ignore.ignore', '0111111111', 'ignore', 'ignore', '100000.00', '100000.00', 'yes');

-- --------------------------------------------------------

--
-- Table structure for table `articles`
--

CREATE TABLE `articles` (
  `article_nr` int(11) NOT NULL,
  `type` enum('usb','torch','powerbank') DEFAULT NULL,
  `status` enum('working','broken') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `articles`
--

INSERT INTO `articles` (`article_nr`, `type`, `status`) VALUES
(1, 'usb', 'working'),
(2, 'torch', 'working'),
(3, 'powerbank', 'working');

-- --------------------------------------------------------

--
-- Table structure for table `camp_reservation`
--

CREATE TABLE `camp_reservation` (
  `spot_nr` int(10) UNSIGNED NOT NULL,
  `account_id` int(10) UNSIGNED NOT NULL,
  `is_paid` enum('yes','no') NOT NULL,
  `status` enum('checked_in','checked_out') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `camp_reservation`
--

INSERT INTO `camp_reservation` (`spot_nr`, `account_id`, `is_paid`, `status`) VALUES
(1, 1, 'yes', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `camp_spots`
--

CREATE TABLE `camp_spots` (
  `spot_nr` int(10) UNSIGNED NOT NULL,
  `is_reserved` enum('no','yes') COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'no',
  `is_vip` enum('no','yes') COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'no'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `camp_spots`
--

INSERT INTO `camp_spots` (`spot_nr`, `is_reserved`, `is_vip`) VALUES
(1, 'no', 'no'),
(2, 'no', 'no'),
(3, 'no', 'no'),
(4, 'no', 'no'),
(5, 'no', 'no'),
(6, 'no', 'no'),
(7, 'no', 'no'),
(8, 'no', 'no'),
(9, 'no', 'no'),
(10, 'no', 'no'),
(11, 'no', 'no'),
(12, 'no', 'no'),
(13, 'no', 'no'),
(14, 'no', 'no'),
(15, 'no', 'no'),
(16, 'no', 'no'),
(17, 'no', 'no'),
(18, 'no', 'no'),
(19, 'no', 'no'),
(20, 'no', 'no'),
(21, 'no', 'no'),
(22, 'no', 'no'),
(23, 'no', 'no'),
(24, 'no', 'no'),
(25, 'no', 'no'),
(26, 'no', 'no'),
(27, 'no', 'no'),
(28, 'no', 'no'),
(29, 'no', 'no'),
(30, 'no', 'no'),
(31, 'no', 'no'),
(32, 'no', 'no'),
(33, 'no', 'no'),
(34, 'no', 'no'),
(35, 'no', 'no'),
(36, 'no', 'no'),
(37, 'no', 'no'),
(38, 'no', 'no'),
(39, 'no', 'no'),
(40, 'no', 'no'),
(41, 'no', 'no'),
(42, 'no', 'no'),
(43, 'no', 'no'),
(44, 'no', 'no'),
(45, 'no', 'no'),
(46, 'no', 'no'),
(47, 'no', 'no'),
(48, 'no', 'no'),
(49, 'no', 'no'),
(50, 'no', 'yes'),
(51, 'no', 'yes'),
(52, 'no', 'yes'),
(53, 'no', 'yes'),
(54, 'no', 'yes'),
(55, 'no', 'yes'),
(56, 'no', 'yes'),
(57, 'no', 'yes'),
(58, 'no', 'yes'),
(59, 'no', 'yes'),
(60, 'no', 'yes'),
(61, 'no', 'yes'),
(62, 'no', 'yes'),
(63, 'no', 'yes'),
(64, 'no', 'yes'),
(65, 'no', 'yes'),
(66, 'no', 'yes'),
(67, 'no', 'yes'),
(68, 'no', 'yes'),
(69, 'no', 'yes'),
(70, 'no', 'yes'),
(71, 'no', 'yes'),
(72, 'no', 'yes'),
(73, 'no', 'yes'),
(74, 'no', 'yes'),
(75, 'no', 'yes'),
(76, 'no', 'yes'),
(77, 'no', 'yes'),
(78, 'no', 'yes'),
(79, 'no', 'yes'),
(80, 'no', 'yes'),
(81, 'no', 'yes'),
(82, 'no', 'yes'),
(83, 'no', 'yes'),
(84, 'no', 'yes'),
(85, 'no', 'yes'),
(86, 'no', 'yes'),
(87, 'no', 'yes'),
(88, 'no', 'yes'),
(89, 'no', 'yes'),
(90, 'no', 'yes'),
(91, 'no', 'yes'),
(92, 'no', 'yes'),
(93, 'no', 'yes'),
(94, 'no', 'yes'),
(95, 'no', 'yes'),
(96, 'no', 'yes'),
(97, 'no', 'yes'),
(98, 'no', 'yes'),
(99, 'no', 'yes'),
(100, 'no', 'yes'),
(101, 'no', 'yes'),
(102, 'no', 'yes'),
(103, 'no', 'yes'),
(104, 'no', 'yes'),
(105, 'no', 'yes'),
(106, 'no', 'yes'),
(107, 'no', 'yes'),
(108, 'no', 'yes'),
(109, 'no', 'yes'),
(110, 'no', 'yes'),
(111, 'no', 'yes'),
(112, 'yes', 'yes'),
(113, 'no', 'yes'),
(114, 'no', 'yes'),
(115, 'no', 'yes'),
(116, 'no', 'yes'),
(117, 'no', 'yes'),
(118, 'no', 'yes'),
(119, 'no', 'yes'),
(120, 'no', 'yes'),
(121, 'no', 'yes'),
(122, 'no', 'yes'),
(123, 'no', 'yes'),
(124, 'no', 'yes'),
(125, 'no', 'yes'),
(126, 'no', 'yes'),
(127, 'no', 'yes'),
(128, 'no', 'yes'),
(129, 'no', 'yes'),
(130, 'no', 'yes'),
(131, 'no', 'yes'),
(132, 'no', 'yes'),
(133, 'no', 'yes'),
(134, 'no', 'yes'),
(135, 'no', 'yes'),
(136, 'no', 'yes'),
(137, 'no', 'yes'),
(138, 'no', 'yes'),
(139, 'no', 'yes'),
(140, 'no', 'yes'),
(141, 'no', 'yes'),
(142, 'no', 'yes'),
(143, 'no', 'yes'),
(144, 'no', 'yes'),
(145, 'no', 'yes'),
(146, 'no', 'yes'),
(147, 'no', 'yes'),
(148, 'no', 'yes'),
(149, 'no', 'yes'),
(150, 'no', 'yes'),
(151, 'no', 'yes'),
(152, 'no', 'yes'),
(153, 'no', 'yes'),
(154, 'no', 'yes'),
(155, 'no', 'yes'),
(156, 'no', 'yes'),
(157, 'no', 'yes'),
(158, 'no', 'yes'),
(159, 'no', 'yes'),
(160, 'no', 'yes'),
(161, 'no', 'yes'),
(162, 'no', 'yes'),
(163, 'no', 'yes'),
(164, 'no', 'yes'),
(165, 'no', 'yes'),
(166, 'no', 'yes'),
(167, 'no', 'yes'),
(168, 'no', 'yes'),
(169, 'no', 'yes'),
(170, 'no', 'yes'),
(171, 'no', 'yes'),
(172, 'no', 'yes'),
(173, 'no', 'yes'),
(174, 'no', 'yes'),
(175, 'no', 'yes'),
(176, 'no', 'yes'),
(177, 'no', 'yes'),
(178, 'no', 'yes'),
(179, 'no', 'yes'),
(180, 'no', 'yes'),
(181, 'no', 'yes'),
(182, 'no', 'yes'),
(183, 'no', 'yes'),
(184, 'no', 'yes'),
(185, 'no', 'yes'),
(186, 'no', 'yes'),
(187, 'no', 'yes'),
(188, 'no', 'yes'),
(189, 'no', 'yes'),
(190, 'no', 'yes'),
(191, 'no', 'yes'),
(192, 'no', 'yes'),
(193, 'no', 'yes'),
(194, 'no', 'yes'),
(195, 'no', 'yes'),
(196, 'no', 'yes'),
(197, 'no', 'yes'),
(198, 'no', 'yes'),
(199, 'no', 'yes'),
(200, 'no', 'yes'),
(201, 'no', 'yes'),
(202, 'no', 'yes'),
(203, 'no', 'yes'),
(204, 'no', 'yes'),
(205, 'no', 'yes'),
(206, 'no', 'yes'),
(207, 'no', 'yes'),
(208, 'no', 'yes'),
(209, 'no', 'yes'),
(210, 'no', 'yes'),
(211, 'no', 'yes'),
(212, 'no', 'yes'),
(213, 'no', 'yes'),
(214, 'no', 'yes'),
(215, 'no', 'yes'),
(216, 'no', 'yes'),
(217, 'no', 'yes'),
(218, 'no', 'yes'),
(219, 'no', 'yes'),
(220, 'no', 'yes'),
(221, 'no', 'yes'),
(222, 'no', 'yes'),
(223, 'no', 'yes'),
(224, 'no', 'yes'),
(225, 'no', 'yes'),
(226, 'no', 'yes'),
(227, 'no', 'yes'),
(228, 'no', 'yes'),
(229, 'no', 'yes'),
(230, 'no', 'yes'),
(231, 'no', 'yes'),
(232, 'no', 'yes'),
(233, 'no', 'yes'),
(234, 'no', 'yes'),
(235, 'no', 'yes'),
(236, 'no', 'yes'),
(237, 'no', 'yes'),
(238, 'no', 'yes'),
(239, 'no', 'yes'),
(240, 'no', 'yes'),
(241, 'no', 'yes'),
(242, 'no', 'yes'),
(243, 'no', 'yes'),
(244, 'no', 'yes'),
(245, 'no', 'yes'),
(246, 'no', 'yes'),
(247, 'no', 'yes'),
(248, 'no', 'yes'),
(249, 'no', 'yes'),
(250, 'no', 'yes');

-- --------------------------------------------------------

--
-- Table structure for table `contactus`
--

CREATE TABLE `contactus` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `message` varchar(255) NOT NULL,
  `date` date DEFAULT NULL,
  `time` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `contactus`
--

INSERT INTO `contactus` (`id`, `name`, `email`, `message`, `date`, `time`) VALUES
(1, 'Subhi Hamidi', 'hamidisubhi@gmail.com', 'subhi is the best', '2019-01-06', '10:29:08'),
(2, 'Mohamed Hamidi', 'Hamidisubhi@gmail.com', 'HAHAHAH I AM THE BES??t', '2019-01-08', '02:51:38'),
(3, 'Mohamed Hamidi', 'Hamidisubhi@gmail.com', 'hahah', '2019-01-10', '06:05:48');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `emp_id` int(11) NOT NULL,
  `fname` varchar(35) NOT NULL,
  `lname` varchar(35) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `phone_nr` varchar(11) NOT NULL,
  `position` enum('admin','manager') NOT NULL,
  `street` varchar(30) NOT NULL,
  `postcode` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`emp_id`, `fname`, `lname`, `email`, `password`, `phone_nr`, `position`, `street`, `postcode`) VALUES
(10, 'Ryan', 'Hermelijn', 'wer@gmail.com', '1212', '4555', 'manager', 'Kaya seru 12', '0000'),
(17, 'subhi', 'Hamidi', 'wdds@dsds', 'sasa', '066471', 'admin', 'knkokek', '5628s');

-- --------------------------------------------------------

--
-- Table structure for table `loaned`
--

CREATE TABLE `loaned` (
  `loaned_id` int(11) NOT NULL,
  `article_nr` int(11) NOT NULL,
  `transaction_id` int(11) NOT NULL,
  `article_status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `loaned`
--

INSERT INTO `loaned` (`loaned_id`, `article_nr`, `transaction_id`, `article_status`) VALUES
(1, 1, 2, 'loaned');

-- --------------------------------------------------------

--
-- Table structure for table `password_reset`
--

CREATE TABLE `password_reset` (
  `ID` int(11) UNSIGNED NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `selector` char(16) DEFAULT NULL,
  `token` char(64) DEFAULT NULL,
  `expires` bigint(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tickets`
--

CREATE TABLE `tickets` (
  `ticket_id` int(10) UNSIGNED NOT NULL,
  `user_id` int(10) UNSIGNED NOT NULL,
  `date_of_purchase` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tickets`
--

INSERT INTO `tickets` (`ticket_id`, `user_id`, `date_of_purchase`) VALUES
(1, 1, '2019-01-11 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transaction_id` int(11) NOT NULL,
  `date` date NOT NULL,
  `time` time NOT NULL,
  `account_id` int(11) UNSIGNED NOT NULL,
  `amount` decimal(11,2) NOT NULL,
  `current_balance` decimal(11,2) NOT NULL,
  `type` enum('deposit','food','items','loan','registration','camp','refund','cancel') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`transaction_id`, `date`, `time`, `account_id`, `amount`, `current_balance`, `type`) VALUES
(1, '2019-01-09', '10:10:25', 1, '1000.00', '10000.00', 'registration'),
(2, '2019-01-09', '06:19:09', 1, '12.00', '10000.00', 'loan');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(10) UNSIGNED NOT NULL,
  `fname` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `lname` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `account_id` int(10) UNSIGNED NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `group_id` int(11) DEFAULT NULL,
  `is_admin` enum('yes','no') COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` enum('checked_in','check_out') COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `is_vip` enum('yes','no') COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `fname`, `lname`, `account_id`, `email`, `group_id`, `is_admin`, `status`, `is_vip`) VALUES
(1, 'ignore', 'ignore', 1, '', NULL, 'yes', NULL, 'yes');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`account_id`),
  ADD UNIQUE KEY `email_2` (`email`),
  ADD KEY `bank_act_nr` (`bank_act_nr`),
  ADD KEY `email` (`email`),
  ADD KEY `bank_act_nr_2` (`bank_act_nr`);

--
-- Indexes for table `articles`
--
ALTER TABLE `articles`
  ADD PRIMARY KEY (`article_nr`);

--
-- Indexes for table `camp_reservation`
--
ALTER TABLE `camp_reservation`
  ADD PRIMARY KEY (`spot_nr`,`account_id`),
  ADD KEY `fk_act_id` (`account_id`);

--
-- Indexes for table `camp_spots`
--
ALTER TABLE `camp_spots`
  ADD PRIMARY KEY (`spot_nr`);

--
-- Indexes for table `contactus`
--
ALTER TABLE `contactus`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`emp_id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `loaned`
--
ALTER TABLE `loaned`
  ADD PRIMARY KEY (`loaned_id`),
  ADD UNIQUE KEY `loaned_id` (`loaned_id`,`article_nr`,`transaction_id`) USING BTREE,
  ADD KEY `article_table_fk` (`article_nr`),
  ADD KEY `transaction_table_fk` (`transaction_id`);

--
-- Indexes for table `password_reset`
--
ALTER TABLE `password_reset`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`ticket_id`),
  ADD KEY `tickets_user_id_foreign` (`user_id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `account_id` (`account_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `users_account_id_foreign` (`account_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `account_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `articles`
--
ALTER TABLE `articles`
  MODIFY `article_nr` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `camp_spots`
--
ALTER TABLE `camp_spots`
  MODIFY `spot_nr` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1003;
--
-- AUTO_INCREMENT for table `contactus`
--
ALTER TABLE `contactus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `loaned`
--
ALTER TABLE `loaned`
  MODIFY `loaned_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `password_reset`
--
ALTER TABLE `password_reset`
  MODIFY `ID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tickets`
--
ALTER TABLE `tickets`
  MODIFY `ticket_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `camp_reservation`
--
ALTER TABLE `camp_reservation`
  ADD CONSTRAINT `fk_act_id` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`),
  ADD CONSTRAINT `fk_spot` FOREIGN KEY (`spot_nr`) REFERENCES `camp_spots` (`spot_nr`);

--
-- Constraints for table `loaned`
--
ALTER TABLE `loaned`
  ADD CONSTRAINT `article_table_fk` FOREIGN KEY (`article_nr`) REFERENCES `articles` (`article_nr`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_table_fk` FOREIGN KEY (`transaction_id`) REFERENCES `transactions` (`transaction_id`) ON UPDATE CASCADE;

--
-- Constraints for table `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE;

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `fk_ACT_Id32` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `Act_id` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
