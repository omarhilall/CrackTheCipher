<form action="" method="post">
	<h1 align="center">Sign Up</h1>
<br>
<br>
User Name: <input type="text" name = "username">
<br>
<br>
Password: <input type="Password" name = "Password">
<br>
<br>
FirstName: <input type="text" name = "FirstName">
<br>
<br>
LastName: <input type="text" name = "LastName">
<br>
<br>
Email: <input type="text" name = "Email">
<br>
<br>
<input type="submit" value="done" name = "submit">
</form>
<?php
if(isset($_POST['submit']))
{
$username=$_POST['username'];
$Password=$_POST['Password'];
$FirstName=$_POST['FirstName'];
$LastName=$_POST['LastName'];
$Email=$_POST['Email'];

$server ="localhost";
$DBUserName="root";
$DBPassword="";
$DB="user";
$con=mysqli_connect($server,$DBUserName,$DBPassword,$DB);
$sql="insert into user(UserName,Password,FirstName,LastName,Email)values('$username','$Password','$FirstName','$LastName','$Email')";
if(mysqli_query($con,$sql)){
header ('Location: index.php');
}
else{
	echo"ERROR:".$sql;
}
}
?>