<!Doctype Html>  
<Html>  
<Body background="https://www.zastavki.com/pictures/1680x1050/2015/Games_Soldiers_in_the_fog_in_the_game_Call_of_Duty_104517_16.jpg">
<style>
h1 {text-align: center;}
</style>
<?php
session_start();
if(empty($_SESSION['ID'])){
	echo "<h1> Welcome to CrackTheCipher</h1> 
<br>
<br>
<a href='login.php'>Login</a>
<br>
<br>
<a href='signup.php'>New User</a>
 ";
}
else{
	echo " Welcome  ".$_SESSION['username'];
	echo "<br>";
	echo "<br>";
	echo"<a href='profile.php'>View Profile</a><br>";
	echo"<a href='intro.php'>Start the game</a><br>";
	echo"<a href='logout.php'>Sign Out</a><br>";

}

?>
</html>

