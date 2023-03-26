using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class validateindividual : MonoBehaviour
{
    public InputField userInputField;
    public Text statusText;
    // defining the variable to be passed into the stats retrevial scripts
    public string scene;//add name of scene 
    public Color loadToColor = Color.black;
    public static string observedStudent;

    public void CheckUserExists()
    {
        StartCoroutine(CheckUserCoroutine());
    }

    IEnumerator CheckUserCoroutine()
    {
        // Get the user input from the input field
        string userInput = userInputField.text;

        // Create a WWWForm and add the user input to it
        WWWForm form = new WWWForm();
        form.AddField("username", userInput);

        // Send a request to the PHP script to check if the user exists
        WWW www = new WWW("http://localhost/unity/Register/CheckUser.php", form);
        yield return www;

        // Check the response from the PHP script
        if (www.text == "0")
        {
            // If the user exists, store the username in observedStudent
            observedStudent = userInput;
            Servers.currentusername = observedStudent;//sets the servers value before retreiving data
            statusText.text = "User found!";
            Initiate.Fade(scene, loadToColor, 2.3f);
            StartCoroutine(mathRetreival.mathRetrievalCoroutine());//call the retreival scripts
            StartCoroutine(compRetreival.computingRetrieval());//call the retreival scripts
            StartCoroutine(scienceRetreival.ScienceRetrievalCoroutine());//call the retreival scripts.
        }
        else
        {
            // If the user does not exist, set the status text to "User not found"
            statusText.text = "User not found";
        }

        // Dispose of the WWW object to clean up memory
        www.Dispose();
    }
}