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
$algebraasked=$_POST["algebraasked"];
$arithmeticasked=$_POST["arithmeticasked"];
$fdpasked=$_POST["fdpasked"];
$algebracorrect=$_POST["algebracorrect"];
$arithmeticcorrect=$_POST["arithmeticcorrect"];
$fdpcorrect=$_POST["fdpcorrect"];

// Now update the database with the new values
// Construct the SQL statements to update each column
$algebraaskedupdater ="UPDATE studentprogress_maths SET algebra_asked ='".$algebraasked."' WHERE username='".$username."'";
$arithmeticaskedupdater ="UPDATE studentprogress_maths SET arithmetic_asked ='".$arithmeticasked."' WHERE username='".$username."'";
$fdpaskedupdater ="UPDATE studentprogress_maths SET fdp_asked ='".$fdpasked."' WHERE username='".$username."'";
$algebracorrectupdater ="UPDATE studentprogress_maths SET algebra_correct ='".$algebracorrect."' WHERE username='".$username."'";
$arithmeticcorrectupdater ="UPDATE studentprogress_maths SET arithmetic_correct ='".$arithmeticcorrect."' WHERE username='".$username."'";
$fdpcorrectupdater ="UPDATE studentprogress_maths SET fdp_correct ='".$fdpcorrect."' WHERE username='".$username."'";

// Execute each SQL statement
mysqli_query($con,$algebraaskedupdater) or die("couldnt update");
mysqli_query($con,$arithmeticaskedupdater) or die("couldnt update");
mysqli_query($con,$fdpaskedupdater) or die("couldnt update");
mysqli_query($con,$algebracorrectupdater) or die("couldnt update");
mysqli_query($con,$arithmeticcorrectupdater) or die("couldnt update");
mysqli_query($con,$fdpcorrectupdater) or die("couldnt update");

// If everything was successful, output "none"
echo "none";
?>