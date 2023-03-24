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
$scienceretreivalquery = "SELECT scienceoverall, overallaverage, biology_asked, biology_correct, chemistry_asked, chemistry_correct, physics_asked, physics_correct FROM studentprogress_science WHERE username = '".$username."';";
$scienceretreivalcheck = mysqli_query($con, $scienceretreivalquery) or die("0");

// Fetch the results 
$row = $scienceretreivalcheck->fetch_assoc();
$scienceOverall = $row["scienceoverall"];
$overallAverage = $row["overallaverage"];
$biologyAsked = $row["biology_asked"];
$biologyCorrect = $row["biology_correct"];
$chemistryAsked = $row["chemistry_asked"];
$chemistryCorrect = $row["chemistry_correct"];
$physicsAsked = $row["physics_asked"];
$physicsCorrect = $row["physics_correct"];

// Return the result as the response
echo $scienceOverall . "," . $overallAverage . "," . $biologyAsked . "," . $biologyCorrect . "," . $chemistryAsked . "," . $chemistryCorrect . "," . $physicsAsked . "," . $physicsCorrect;
mysqli_close($con);
exit();
?>
