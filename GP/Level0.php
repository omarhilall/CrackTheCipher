<html>
<?php
session_start();


echo "<h1>Ceaser Cipher</h1>";
//echo "Welcome to CrackTheCipher.. We will help you to be able to crack the cipher <br> ";
echo "<br>";
echo "<h2>The Caesar Cipher is a monoalphabetic rotation cipher used by Gaius Julius Caesar. <br> Simply, Caesar rotated 
each letter of the plaintext forward with a certain key as an example lets use the number three to encrypt, So that A became D, B became E, etc. <br>
 and vice versa with the decryption as we go backword 3 times to decrypt,
  So that D became A, E became B, etc </h2> <br>";
echo "<br>";
echo "<br>";
if(array_key_exists('button1', $_POST)) {
    button1();
}
else if(array_key_exists('button2', $_POST)) {
    button2();
}
else if(array_key_exists('button3', $_POST)) {
    button3();
}
function button1() {

        header('Location:level0try.php');   
}
function button2() {
        header('Location:level0test.php');
}
function button3() {
        header('Location:intro.php');
}
?> 
<form method="post">
        <input type="submit" name="button1"
                class="button" value="try it yourself" />
<br>          
<br>          
<br>          

        <input type="submit" name="button2"
                class="button" value="test yourself" />
<br>
<br>
<br>

        <input type="submit" name="button3"
                class="button" value="Back" />
    </form>
</html>