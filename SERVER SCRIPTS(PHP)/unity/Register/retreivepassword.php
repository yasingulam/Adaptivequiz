<?php
    $con = mysqli_connect('localhost','root','','taylors_test');
    //creates conncetion, check that it happened

    if (mysqli_connect_errno()){

        echo "0";// an error occured this 0 means errro=true and con failed
        exit();// else then do nothing
    }
    $username = $_POST["name"];
    

    //now need to see if name exists
    $passwordcheckquery = "SELECT password FROM login WHERE username ='".$username."';";// gets the row for for that username
    $passwordcheck = mysqli_query($con, $passwordcheckquery) or die("0");//error is number 0 this time passwordcheckquery failed
    $row = $passwordcheck -> fetch_assoc();
    if (mysqli_num_rows($passwordcheck)> 0){
        echo $row["password"];// password exists, send it back as a text
        exit();
    }
    
    else{
        echo "0";
    }

?>