

<?php
$selector = filter_input(INPUT_GET, 'selector');
$validator = filter_input(INPUT_GET, 'validator');
if ( false !== ctype_xdigit( $selector ) && false !== ctype_xdigit( $validator ) ) :
?>


<form action="?page=reset" method="post">

    <input type="hidden" name="selector" value="<?php echo $selector; ?>">
    <input type="hidden" name="validator" value="<?php echo $validator; ?>">
<br>
New Password: <input type="password" name="password" size="20" /><br />
Confirm Password: <input type="password" name="confirmpassword" size="20" /><br />
<input type="submit" name="ResetPasswordForm" value=" Reset Password " />
</form>


<?php endif; ?>
<?php

?>