<?php
    $con = mysqli_connect('localhost','root','','taylors_test');
    //cretes conncetion, check thjat it happened

    if (mysqli_connect_errno()){

        echo "1";// an error occured this 1 means errro=true and con failed
        exit();// else then do nothing
    }
    $username = $_POST["name"];
    $password = $_POST["password"];// relays the username and password passed in from the unity script

    //nnow need to see if name exists
    $namecheckquery = "SELECT username FROM login WHERE username='".$username."';";// checks if the name already exists in the table or not
    $namecheck = mysqli_query($con, $namecheckquery) or die("2");//error is number 2 this time namecheckquery failed
    if (mysqli_num_rows($namecheck)> 0){
        echo "3";// name already exists, send 3 back as an error
        exit();
    }


    //time to add the user to the table afte it has been validated there are no errors
    $insertuserquery = "INSERT INTO login(username, password) VALUES ('".$username."','".$password."');";// adds the username to the database as well as the password
    mysqli_query($con,$insertuserquery) or die("4"); // insert has failed, basically unknown error

    echo("0");

?>