<?php 
session_start();
$server ="localhost";
$DBUserName="root";
$DBPassword="";
$DB="user";

$con=mysqli_connect($server,$DBUserName,$DBPassword,$DB);
$sql="delete from user where ID =".$_SESSION['ID'];

$result=mysqli_query($con,$sql);
if($result)
{
	session_destroy();
	header ('Location: index.php');
}
else
{
	echo $sql;
	echo "<br>";
	echo"<a href='index.php'>Back</a><br>";
}
?>