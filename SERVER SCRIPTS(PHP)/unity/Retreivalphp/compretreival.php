<?php
$con = mysqli_connect('localhost', 'root', '', 'taylors_test');

// Check that the connection was successful
if (mysqli_connect_errno()) {
    echo "0";
    exit();
}

// Get the username from the POST data
$username = $_POST["name"];

// Prepare the query to retrieve the student progress data for the specified user
$computingretrievalquery = "SELECT computingoverall, overallaverage, hardware_asked, hardware_correct, software_asked, software_correct, programming_asked, programming_correct FROM studentprogress_computing WHERE username = '".$username."';";
$computingretrievalcheck = mysqli_query($con, $computingretrievalquery) or die("0");

// Fetch the results 
$row = $computingretrievalcheck->fetch_assoc();
$computingOverall = $row["computingoverall"];
$overallAverage = $row["overallaverage"];
$hardwareAsked = $row["hardware_asked"];
$hardwareCorrect = $row["hardware_correct"];
$softwareAsked = $row["software_asked"];
$softwareCorrect = $row["software_correct"];
$programmingAsked = $row["programming_asked"];
$programmingCorrect = $row["programming_correct"];

// Return the result as the response
echo $computingOverall . "," . $overallAverage . "," . $hardwareAsked . "," . $hardwareCorrect . "," . $softwareAsked . "," . $softwareCorrect . "," . $programmingAsked . "," . $programmingCorrect;
mysqli_close($con);
exit();

?>
