$myPDO = new PDO('mysql:host=studmysql01.fhict.local;dbname=dbi378474', 'dbi378474', '123456789');
// set the PDO error mode to exception
$myPDO->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);