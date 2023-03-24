<?php
// Set up database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "taylors_test";

$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

//Get number of questions needed for each topic
$biologyCount = $_GET["biologyquestioncount"];
$chemistryCount = $_GET["chemistryquestioncount"];
$physicsCount = $_GET["physicsquestioncount"];


// Prepare SQL query to get questions from database
//$sql = "SELECT Question, Option1, Option2, Option3, Option4, correctanswer, questionsubject, questiontopic FROM sciencequestions ";

// Add WHERE clauses to filter by topic and limit number of questions
$sql = " (SELECT Question, Option1, Option2, Option3, Option4, correctanswer, questionsubject, questiontopic FROM sciencequestions WHERE (questiontopic='biology' AND questionsubject='science')  LIMIT $biologyCount )";
$sql .= "UNION";
$sql .= "(SELECT Question, Option1, Option2, Option3, Option4, correctanswer, questionsubject, questiontopic FROM sciencequestions WHERE (questiontopic='chemistry' AND questionsubject='science') ORDER BY RAND() LIMIT $chemistryCount )";
$sql .= "UNION";
$sql .= "(SELECT Question, Option1, Option2, Option3, Option4, correctanswer, questionsubject, questiontopic FROM sciencequestions WHERE (questiontopic='physics' AND questionsubject='science') ORDER BY RAND() LIMIT $physicsCount )";
//"ORDER BY RAND()" clause randomizes the order of the results. The "LIMIT" clause limits the number of questions retrieved to the value of "$biologyCount".
//"UNION ALL" operator to combine the results of the first query with the results of the next query.


// Execute SQL query
$result = $conn->query($sql);

// Convert result set to comma-separated string
// Convert result set to pipe-separated string
$output = "";
if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        $output .= implode("|", $row) . "\n";
    }
} else {
    echo "0 results";
}


// Close database connection
$conn->close();

// Return comma-separated string to Unity
echo $output;
?>
