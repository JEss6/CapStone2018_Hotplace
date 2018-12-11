<?php
$servername = "localhost";
$username = "root";
$password = "12345";
$dbname = "mydb";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 



 $user = $_POST["checkname"];
 $password = $_POST["checkpassword"];

$sql = "SELECT username FROM mytable1 where username='$user'";
$result = $conn->query($sql);


if ($result->num_rows > 0) {
	
    // output data of each row
    while($row = $result->fetch_assoc()) {
		
		
      echo "ok";
		
	}  
} else {
    echo "Mistmatch";
}

 $conn->close();
?>



