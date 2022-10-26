<form action="" method="post">
	<h1 align="center">Your Profile</h1>
</form>
<?php
session_start();
echo " FirstName:  ".$_SESSION['FirstName'];
	echo "<br>";
	echo "<br>";
	echo " LastName:  ".$_SESSION['LastName'];
	echo "<br>";
	echo "<br>";
	echo " Email: ".$_SESSION['Email'];
	echo "<br>";
	echo "<br>";
	// echo " Score: ".$_SESSION['score'];
	// echo "<br>";
	// echo "<br>";
	// echo " Level: ".$_SESSION['level'];
	echo"<a href='profile.php'>Back</a><br>";

?>
