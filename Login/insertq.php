<?php

$host="localhost";
$user="root";
$pass="12345";
$db="mydb";

$con = mysqli_connect($host, $user , $pass ,$db);
if($con) {

	echo "connect successfully";

}



 $username = $_POST["name"];
 $password = $_POST["password"];
 $salt = "\$5\$rounds=5000\$" ."steamedhams".$username."\$";  
 $hash = crypt($password, $salt);

$sql  = " INSERT INTO mytable1 (username,hash,salt) VALUES ( '$username','$hash','$salt')";
echo $username ;

$result = mysqli_query($con, $sql);

if($result == false){
    echo mysqli_error($con);
}


?>
