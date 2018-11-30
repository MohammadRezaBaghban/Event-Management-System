<?php
require_once "random_compat/lib/random.php";
try {
    require '../database/dbconnect.php';

} catch (PDexception $e) {
    echo "failed to connect to db failed";
}

if (isset($_POST["ForgotPassword"])) {
    // validate submitted e-mail address

    if (filter_var($_POST["email"], FILTER_VALIDATE_EMAIL)) {
        $email = $_POST["email"];
    } else {
        echo "email is not valid";
        exit;
    }
    // Check to see if a user exists with this e-mail
    $query = $conn->prepare('SELECT email FROM accounts WHERE email = :email');
    $query->bindParam(':email', $email);
    $query->execute();
    $userExists = $query->fetch(PDO::FETCH_ASSOC);
    if ($userExists["email"]) {
        // Create a unique token. This will never leave PHP unencrypted.
        $selector = bin2hex(random_bytes(8));
        //$selector = bin2hex(random_int(10000000,99999999));
        $token = random_bytes(32);
        //$token = random_int(10000000000000000000000000000000,99999999999999999999999999999999);
        $validator = bin2hex($token);

        $url = "hhf.hera.fhict.nl/php/?page=resetpass&selector=$selector&validator=$validator";

        // Token expiration
        $expires = new DateTime('NOW');
        $expires->add(new DateInterval('PT01H'));

        // Create the unique user password reset key
        $query = $conn->prepare('delete FROM password_reset WHERE email = :email');
        $query->bindParam(':email', $email);
        $query->execute();

        $query = $conn->prepare('insert into password_reset values(id,:email,:selector,:token,:expires) ');
        $hashed = hash('sha256', $token);
        $query->bindParam(':email', $email);
        $query->bindParam(':selector', $selector);
        $query->bindParam(':token', $hashed);
        $expiresforSub = $expires->format('U');
        $query->bindParam(':expires', $expiresforSub);
        $query->execute();
        $conn = null;

        // Create a url which we will direct them to reset their password
        $pwrurl = $url;
        // Mail them their key
        $mailbody = '<html><body>';
        $mailbody .= "Dear user,<br> <strong>If this e-mail does not apply to you please ignore it.<strong><br><br> It appears that you have requested a password reset at our website hhf.hera.fhict.nl <br> To reset your password, please click the link below. 
        <br><br><strong>If you cannot click it, please paste it into your web browser's address bar.</strong><br>  
        ";
        $mailbody .= $pwrurl;
        $mailbody .= "<br>Regards, Admin";
        $mailbody .= '</body></html>';
        $headers = "MIME-Version: 1.0\r\n";
        $headers .= "Content-Type: text/html; charset=ISO-8859-1\r\n";
        mail($userExists["email"], "hhf.hera.fhict.nl - Password Reset", $mailbody, $headers);
        echo "Your password recovery key has been sent to your e-mail address.";
    } else
        echo "No user with that e-mail address exists.";
} else {
    echo "form not submitted successfully!";
}

?>