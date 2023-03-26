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

$algebraCount = $_GET["algebraquestioncount"];
$arithmeticCount = $_GET["arithmeticquestioncount"];
$fdpCount = $_GET["fdpquestioncount"];


// Prepare SQL query to get questions from database

// Add WHERE clauses to filter by topic and limit number of questions
$sql = "(SELECT Question, Option1, Option2, Option3, Option4, correctanswer, questionsubject, questiontopic FROM mathsquestions WHERE (questiontopic='algebra' AND questionsubject='maths') ORDER BY RAND() LIMIT $algebraCount )";
$sql .= " UNION ";
$sql .= "(SELECT Question, Option1, Option2, Option3, Option4, correctanswer, questionsubject, questiontopic FROM mathsquestions WHERE (questiontopic='arithmetic' AND questionsubject='maths') ORDER BY RAND() LIMIT $arithmeticCount )";
$sql .= " UNION ";
$sql .= "(SELECT Question, Option1, Option2, Option3, Option4, correctanswer, questionsubject, questiontopic FROM mathsquestions WHERE (questiontopic='FDP' AND questionsubject='maths') ORDER BY RAND() LIMIT $fdpCount )";
//"ORDER BY RAND()" clause randomizes the order of the results. The "LIMIT" clause limits the number of questions retrieved to the value of "$algebraCount".
//"UNION ALL" operator to combine the results of the first query with the results of the next query.


// Execute SQL query
$result = $conn->query($sql);

// Convert result set to comma-separated string
$output = "";
if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        $output .= implode(",", $row) . "\n";
    }
} else {
    echo "0 results";
}

// Close database connection
$conn->close();

// Return comma-separated string to Unity
echo $output;
?>
