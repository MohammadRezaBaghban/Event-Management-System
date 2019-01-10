<?php
echo "nice";
require './vendor/autoload.php';
echo "<br>";
$generator = new \Picqer\Barcode\BarcodeGeneratorPNG();
$barcode = $generator->getBarcode(17, $generator::TYPE_CODABAR);

function SendMail($username, $userid, $mail)
{
    $message = '<html><body>';
    $message .= 'Dear <strong>';
    $message .= $username . '!</strong>,<br> you have booked your place successfully in our <strong>HHF</strong> event.<strong><br>';
    $message .= $userid . '</strong> is your user id and below you code find your BarCode, in case of any accident you can always use them 
    for the entrance of the event.';
    $message .= '<br><br>';
    $message .= '<br> Incase you need to contact us,<br> Feel free to send us an email at:<br><br>';
    $message .= 'XXXXX@gmail.com <br> <strong>HHF Admins</strong>';
    $message .= '</body></html>';
    $headers = "MIME-Version: 1.0\r\n";
    $headers .= "Content-Type: text/html; charset=ISO-8859-1\r\n";
    mail($mail, " XXX || Booking confirmation", $message, $headers);
}

SendMail("Subhi","1","i400320@student.fontys.nl");

echo '<img src="data:image/png;base64,' . base64_encode($barcode) . '">';
echo "<br> nice";
?>

