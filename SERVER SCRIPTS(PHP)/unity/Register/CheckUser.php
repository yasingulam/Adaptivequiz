<?php
    $con = mysqli_connect('localhost','root','','taylors_test');
    // check that the connection was successful
    if (mysqli_connect_errno()){
        echo "0"; // an error occurred, return 0 to indicate failure
        exit();
    }
    $username = $_POST["username"];
    $usercheckquery = "SELECT * FROM login WHERE username = '".$username."';";
    $usercheck = mysqli_query($con, $usercheckquery) or die("0");
    if (mysqli_num_rows($usercheck)> 0){
        echo "0"; // user exists, return 0 to indicate the user exists
        exit();
    }
    else{
        echo "1"; // user does not exist, return 1 to indicate failure
    }
?>