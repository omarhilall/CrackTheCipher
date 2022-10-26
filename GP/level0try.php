<?php

 
echo "<h1>Ceaser Cipher Try</h1>";
echo "<br>";



function encrypt($text, $s)
{
    $result = "";
 
    // traverse text
    for ($i = 0; $i < strlen($text); $i++)
    {
   
        if (ctype_upper($text[$i]))
            $result = $result.chr((ord($text[$i]) +
                               $s - 65) % 26 + 65);
 
    else
        $result = $result.chr((ord($text[$i]) +
                           $s - 97) % 26 + 97);
    }
 
    return $result;
}
 ?>
<form method="post">
    Key : <select name = "key">  
  <option value="0">0</option>  
  <option value="1">1</option>  
  <option value="2">2 </option>  
  <option value="3">3 </option>  
  <option value="4">4 </option>  
  <option value="5">5 </option>  
  <option value="6">6 </option>  
  <option value="7">7 </option>  
  <option value="8">8 </option>  
  <option value="9">9 </option>  
</select>   
    Plain text: <input type="text" name = "plaintext">
<br>
<br>
        <input type="submit" name="button1"
                class="button" value="Try" />
          <br>
          <br>
        <input type="submit" name="button2"
                class="button" value="Back" />
    </form>
</html>
 <?php
 if(array_key_exists('button1', $_POST)) {
    button1();
}
else if(array_key_exists('button2', $_POST)) {
    button2();
}

function button1() {
        $text =$_POST['plaintext'];
$s = $_POST['key'];
echo "Text : " . $text;
echo "\nShift: " . $s;

echo "\nCipher: " . encrypt($text, $s);


}
function button2() {
        header('Location:level0.php');
}

 ?>
