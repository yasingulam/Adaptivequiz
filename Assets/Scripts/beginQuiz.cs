using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //This is an imported class which I will be using for navigation

public class beginQuiz : MonoBehaviour
{
    public string scene;//add name of scene 
    public Color loadToColor = Color.black;
    // Reference to the Text component to display messages
    public Text messageText;

    // Public string to store the selected subject
    public static string parsedsubject;

    // Get the selected option from the Dropdown component
 
    
 
    // Function to be called when the button is clicked

    public void beginquiz()
    {


        // Check the value of the option and set parsedsubject accordingly
        if (DropDown.option == 0)
        {
            // If option is 0, display "please enter an option" message
            messageText.text = "please enter an option";
        }
        else if (DropDown.option == 1)
        {
            // If option is 1, set parsedsubject to "computing"
            parsedsubject = "computing";
            Initiate.Fade(scene, loadToColor, 2.3f);

        }
        else if (DropDown.option == 2)
        {
            // If option is 2, set parsedsubject to "maths"
            parsedsubject = "maths";
            Initiate.Fade(scene, loadToColor, 2.3f);
        }
        else if (DropDown.option == 3)
        {
            // If option is 3, set parsedsubject to "science"
            parsedsubject = "science";
            Initiate.Fade(scene, loadToColor, 2.3f);
        }
        Debug.Log(parsedsubject);
    }
}