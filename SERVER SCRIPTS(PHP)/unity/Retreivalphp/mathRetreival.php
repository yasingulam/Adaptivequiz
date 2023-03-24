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
$mathsRetrievalQuery = "SELECT mathsoverall, overallaverage, algebra_asked, algebra_correct, arithmetic_asked, arithmetic_correct, fdp_asked, fdp_correct FROM studentprogress_maths WHERE username = '".$username."';";
$mathsRetrievalCheck = mysqli_query($con, $mathsRetrievalQuery) or die("0");

// Fetch the results and encode them as a comma-separated string
$row = $mathsRetrievalCheck->fetch_assoc();
$relevantdata = $row["mathsoverall"] . "," . $row["overallaverage"] . "," . $row["algebra_asked"] . "," . $row["algebra_correct"] . "," . $row["arithmetic_asked"] . "," . $row["arithmetic_correct"] . "," . $row["fdp_asked"] . "," . $row["fdp_correct"];

// Return the string as the response
echo $relevantdata;
exit();

?>
