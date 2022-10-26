
<?php
session_start();


echo " Welcome ".$_SESSION['username'];

	echo "<br>";
	echo "<br>";
	echo"<a href='view.php'>Profile</a><br>";
	echo"<a href='Edit.php'>Edit Profile</a><br>";
	echo"<a href='delete.php'>Delete Account</a><br>";
	echo"<a href='logout.php'>Sign Out</a><br>";
	echo"<a href='index.php'>Back</a><br>";



?>