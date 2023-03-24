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
$hardwareasked=$_POST["hardwareasked"];
$softwareasked=$_POST["softwareasked"];
$programmingasked=$_POST["programmingasked"];
$hardwarecorrect=$_POST["hardwarecorrect"];
$softwarecorrect=$_POST["softwarecorrect"];
$programmingcorrect=$_POST["programmingcorrect"];

// Now update the database with the new values
// Construct the SQL statements to update each column
$hardwareaskedupdater ="UPDATE studentprogress_computing SET hardware_asked ='".$hardwareasked."' WHERE username='".$username."'";
$softwareaskedupdater ="UPDATE studentprogress_computing SET software_asked ='".$softwareasked."' WHERE username='".$username."'";
$programmingaskedupdater ="UPDATE studentprogress_computing SET programming_asked ='".$programmingasked."' WHERE username='".$username."'";
$hardwarecorrectupdater ="UPDATE studentprogress_computing SET hardware_correct ='".$hardwarecorrect."' WHERE username='".$username."'";
$softwarecorrectupdater ="UPDATE studentprogress_computing SET software_correct ='".$softwarecorrect."' WHERE username='".$username."'";
$programmingcorrectupdater ="UPDATE studentprogress_computing SET programming_correct ='".$programmingcorrect."' WHERE username='".$username."'";

// Execute each SQL statement
mysqli_query($con,$hardwareaskedupdater) or die("couldnt update");
mysqli_query($con,$softwareaskedupdater) or die("couldnt update");
mysqli_query($con,$programmingaskedupdater) or die("couldnt update");
mysqli_query($con,$hardwarecorrectupdater) or die("couldnt update");
mysqli_query($con,$softwarecorrectupdater) or die("couldnt update");
mysqli_query($con,$programmingcorrectupdater) or die("couldnt update");

// If everything was successful, output "none"
echo "none";
?>