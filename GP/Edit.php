<form action="" method="post">
<h1>Edit</h1> 
<?php
session_start();

?>

First Name:	
<br>
<?php
echo "<input type='text' name= 'FirstName' value=".$_SESSION['FirstName'].">";
?>
<br>
Last Name:
<br>
<input type="text" name= "LastName" value="<?=$_SESSION['LastName']?>">
<br>
User Name:	
<br>
<input type="text" name= "username" value="<?=$_SESSION['username']?>">
<br>
Email:
<br>
<input type="text" name= "Email" value="<?=$_SESSION['Email']?>">
<br>
Password:
<br>
<input type="Password" name= "Password" value="<?php=$_SESSION['Password']?>">
<br>
<br>
<input type="submit" name= "submit">
<br>
<br>
<a href='profile.php'>Back</a><br>


</form>
<?php
if(isset($_POST['submit']))
{
	$username=$_POST['username'];
	$password=$_POST['Password'];

	$FirstName=$_POST['FirstName'];
	$LastName=$_POST['LastName'];
	$Email=$_POST['Email'];
	$Password=$_POST['Password'];

	$server="localhost";
	$DBUserName="root";
	$DBPassword="";
	$DB="user";
	$con=mysqli_connect($server,$DBUserName,$DBPassword,$DB);
	$sql="update user set UserName='$username',Password='$Password',FirstName='$FirstName',LastName='$LastName',Email='$Email' where ID=".$_SESSION['ID'];
	if(mysqli_query($con,$sql))
	 {
		header('Location: profile.php');
	 }
	 else
	{
		echo $sql;
	}
}
?>