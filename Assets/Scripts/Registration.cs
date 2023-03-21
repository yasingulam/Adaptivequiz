using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Text statusmessage;
    public Button submitButton;

    public void StartRegister()
    {
        StartCoroutine(Register());
    }
    //  This essentially all allows us to set up the buttons and call a function which will be able to access the localhost link,
    
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);//sends this data from the input field to the form thats bewing passed to the php script
        form.AddField("password",passwordField.text);//sends this data from the input field to the form thats bewing passed to the php script

        WWW www = new WWW("http://localhost/unity/Register/register.php", form);// this is used to access the directory of the PHP file so its contents can be acccessed.
        yield return www;// returns a response so that the rest of code can continue to run
        if (www.text == "0")
        {
            Debug.Log("user created successfully");// if there is no error returned from the php script
            statusmessage.text = "User created successfully";

        }// returns text from the PHP info
        else
        {
            Debug.Log("User creation failed, check your input");// if the error is present(>0) then say this
            statusmessage.text = "create user failed, please check connection and input";

        }
        www.Dispose();

    }

    public void VerifyInputs()// VALIDATION!!!!
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 3);// ensures username and password are greter than 3 characters each This is validation.

    }
}