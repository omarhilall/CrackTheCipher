<form action="" method="post">
	<h1 align="center">Log in</h1>
<br>
<br>
User Name: <input type="text" name = "username">
<br>
<br>
Password: <input type="Password" name = "Password">
<br>
<br>
<input type="submit" value="Log in" name = "submit">
</form>

<?php
if(isset($_POST['submit']))
{
$username=$_POST['username'];
$Password=$_POST['Password'];

$server ="localhost";
$DBUserName="root";
$DBPassword="";
$DB="user";
$con=mysqli_connect($server,$DBUserName,$DBPassword,$DB);

$sql="select * from user where UserName='$username' and Password='$Password'";
$result=mysqli_query($con,$sql);
session_start();

while($row=mysqli_fetch_array($result))
{
	echo $row['ID'];
	echo $row['username'];
	//echo $row['Password'];
	$_SESSION['username']=$username;
	$_SESSION['ID']= $row['ID'];
	$_SESSION['FirstName']=$row['FirstName'];
	$_SESSION['LastName']=$row['LastName'];
	$_SESSION['Email']=$row['Email'];
	
	header ('Location: index.php');
}

if(mysqli_query($con,$sql)){
	echo"User name or password is incorrect <br>";
 	echo"<a href='signup.php'>Sign up</a><br>";
 	 echo"<a href='index.php'>Back</a><br>";



}
else{
	echo"ERROR:".$sql;
}
}
?>