<?php

$con = mysqli_connect('localhost','root','','taylors_test');
    // check that the connection was successful
if (mysqli_connect_errno()){
    echo "0"; // an error occurred, return 0 to indicate failure
    exit();
}

// Retrieve data from the three tables
$query1 = "SELECT SUM(hardware_asked) AS hardware_asked, SUM(hardware_correct) AS hardware_correct, SUM(software_asked) AS software_asked, SUM(software_correct) AS software_correct, SUM(programming_asked) AS programming_asked, SUM(programming_correct) AS programming_correct FROM studentprogress_computing";
$result1 = mysqli_query($con, $query1);

$query2 = "SELECT SUM(algebra_asked) AS algebra_asked, SUM(algebra_correct) AS algebra_correct, SUM(arithmetic_asked) AS arithmetic_asked, SUM(arithmetic_correct) AS arithmetic_correct, SUM(fdp_asked) AS fdp_asked, SUM(fdp_correct) AS fdp_correct FROM studentprogress_maths";
$result2 = mysqli_query($con, $query2);

$query3 = "SELECT SUM(biology_asked) AS biology_asked, SUM(biology_correct) AS biology_correct, SUM(chemistry_asked) AS chemistry_asked, SUM(chemistry_correct) AS chemistry_correct, SUM(physics_asked) AS physics_asked, SUM(physics_correct) AS physics_correct FROM studentprogress_science";
$result3 = mysqli_query($con, $query3);

//retreive the number of students (number of rows), same for all 3
$query4="SELECT COUNT(*) FROM studentprogress_computing";
$result4 = mysqli_query($con, $query4);


// Store the results in variables
$row1 = mysqli_fetch_assoc($result1);
$row2 = mysqli_fetch_assoc($result2);
$row3 = mysqli_fetch_assoc($result3);
$row4 = mysqli_fetch_assoc($result4);
// Close the database connection
mysqli_close($con);

// Send the results to Unity
echo $row1['hardware_asked'] . "," . $row1['hardware_correct'] . "," . $row1['software_asked'] . "," . $row1['software_correct'] . "," . $row1['programming_asked'] . "," . $row1['programming_correct'] . "," . $row2['algebra_asked'] . "," . $row2['algebra_correct'] . "," . $row2['arithmetic_asked'] . "," . $row2['arithmetic_correct'] . "," . $row2['fdp_asked'] . "," . $row2['fdp_correct'] . "," . $row3['biology_asked'] . "," . $row3['biology_correct'] . "," . $row3['chemistry_asked'] . "," . $row3['chemistry_correct'] . "," . $row3['physics_asked'] . "," . $row3['physics_correct'] . "," . $row4['COUNT(*)'];

?>


