<?php
$con = mysqli_connect('localhost', 'root', '', 'taylors_test');
// Check that the connection was successful
if (mysqli_connect_errno()) 
{
    echo "0";
    exit();
}

// Load variables that were passed in from Unity form into PHP variables
$username=$_POST["name"];
$biologyasked=$_POST["biologyasked"];
$chemistryasked=$_POST["chemistryasked"];
$physicsasked=$_POST["physicsasked"];
$biologycorrect=$_POST["biologycorrect"];
$chemistrycorrect=$_POST["chemistrycorrect"];
$physicscorrect=$_POST["physicscorrect"];

// Now update the database with the new values
// Construct the SQL statements to update each column
$biologyaskedupdater ="UPDATE studentprogress_science SET biology_asked ='".$biologyasked."' WHERE username='".$username."'";
$chemistryaskedupdater ="UPDATE studentprogress_science SET chemistry_asked ='".$chemistryasked."' WHERE username='".$username."'";
$physicsaskedupdater ="UPDATE studentprogress_science SET physics_asked ='".$physicsasked."' WHERE username='".$username."'";
$biologycorrectupdater ="UPDATE studentprogress_science SET biology_correct ='".$biologycorrect."' WHERE username='".$username."'";
$chemistrycorrectupdater ="UPDATE studentprogress_science SET chemistry_correct ='".$chemistrycorrect."' WHERE username='".$username."'";
$physicscorrectupdater ="UPDATE studentprogress_science SET physics_correct ='".$physicscorrect."' WHERE username='".$username."'";

// Execute each SQL statement
mysqli_query($con,$biologyaskedupdater) or die("couldnt update");
mysqli_query($con,$chemistryaskedupdater) or die("couldnt update");
mysqli_query($con,$physicsaskedupdater) or die("couldnt update");
mysqli_query($con,$biologycorrectupdater) or die("couldnt update");
mysqli_query($con,$chemistrycorrectupdater) or die("couldnt update");
mysqli_query($con,$physicscorrectupdater) or die("couldnt update");

// If everything was successful, output "none"
echo "none";
?>