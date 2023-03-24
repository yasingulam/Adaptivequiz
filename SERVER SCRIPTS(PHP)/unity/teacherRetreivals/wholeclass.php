<?php
// connect to the database
$servername = "localhost";
$username = "username";
$password = "password";
$dbname = "database";
$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// query the database to retrieve the mean and average scores for each subject and topic
$sql = "SELECT
    'computing' AS subjectName,
    AVG(hardware_correct + software_correct + programming_correct) AS meanScore,
    CONCAT('hardware') AS topicName,
    AVG(hardware_correct) AS averageScore
    FROM computing
    UNION ALL
    SELECT
    'computing' AS subjectName,
    AVG(hardware_correct + software_correct + programming_correct) AS meanScore,
    CONCAT('software') AS topicName,
    AVG(software_correct) AS averageScore
    FROM computing
    UNION ALL
    SELECT
    'computing' AS subjectName,
    AVG(hardware_correct + software_correct + programming_correct) AS meanScore,
    CONCAT('programming') AS topicName,
    AVG(programming_correct) AS averageScore
    FROM computing
    UNION ALL
    SELECT
    'maths' AS subjectName,
    AVG(algebra_correct + arithmetic_correct + fdp_correct) AS meanScore,
    CONCAT('algebra') AS topicName,
    AVG(algebra_correct) AS averageScore
    FROM maths
    UNION ALL
    SELECT
    'maths' AS subjectName,
    AVG(algebra_correct + arithmetic_correct + fdp_correct) AS meanScore,
    CONCAT('arithmetic') AS topicName,
    AVG(arithmetic_correct) AS averageScore
    FROM maths
    UNION ALL
    SELECT
    'maths' AS subjectName,
    AVG(algebra_correct + arithmetic_correct + fdp_correct) AS meanScore,
    CONCAT('fdp') AS topicName,
    AVG(fdp_correct) AS averageScore
    FROM maths
    UNION ALL
    SELECT
    'science' AS subjectName,
    AVG(biology_correct + chemistry_correct + physics_correct) AS meanScore,
    CONCAT('biology') AS topicName,
    AVG(biology_correct) AS averageScore
    FROM science
    UNION ALL
    SELECT
    'science' AS subjectName,
    AVG(biology_correct + chemistry_correct + physics_correct) AS meanScore,
    CONCAT('chemistry') AS topicName,
    AVG(chemistry_correct) AS averageScore
    FROM science
    UNION ALL
    SELECT
    'science' AS subjectName,
    AVG(biology_correct + chemistry_correct + physics_correct) AS meanScore,
    CONCAT('physics') AS topicName,
    AVG(physics_correct) AS averageScore
    FROM science";

$result = $conn->query($sql);

// format the data into an array of SubjectStats objects and convert to JSON format
$subjectStatsList = array();
$subjectName = "";
$subjectStats = null;
while ($row = $result->fetch_assoc()) {
    if ($subjectName != $row["subjectName"]) {
        if ($subjectStats != null) {
            array_push($subjectStatsList, $subjectStats);
        }
        $subjectName = $row["subjectName"];
        $subjectStats = array(
            "subjectName" => $subjectName,
            "meanScore" => $row["meanScore"],
            "topicStatsList" => array()
        );
    }
    array_push($subjectStats["topicStatsList"], array(
        "topicName" => $row["topicName"],
        "averageScore" => $row["averageScore"]
    ));
    }
    
    if ($subjectStats != null) {
    array_push($subjectStatsList, $subjectStats);
    }
    
    $json = json_encode($subjectStatsList);
    
    // print the JSON data
    echo $json;
    
    // close the database connection
    $conn->close();
?>