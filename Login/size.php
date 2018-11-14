<?php
$servername = "localhost";
$username = "root";
$password = "12345";
$dbname = "dbhell";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 



 $user = $_POST["checkname"];
 $password = $_POST["checkpassword"];

$sql = "SELECT name, width FROM size where width<'$user'";
$result = $conn->query($sql);


if ($result->num_rows > 0) {
	
    // output data of each row
    while($row = $result->fetch_assoc()) {
		
		
      echo "   name: " .$row['name']." info: ".$row['width']."cm";
		
	}  
} else {
    echo "0 result";
}

 $conn->close();
?>



