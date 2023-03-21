using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mathRetreival : MonoBehaviour
{
    // Define public static variables that will store the user's progress
    public static string mathOverall;
    public static string overallAverage;
    public static string algebraAsked;
    public static string algebraCorrect;
    public static string arithmeticAsked;
    public static string arithmeticCorrect;
    public static string fdpAsked;
    public static string fdpCorrect;

    void Start()
    {
        // Call the coroutine to retrieve the user's progress
        StartCoroutine(mathRetrievalCoroutine());
    }

    IEnumerator mathRetrievalCoroutine()
    {
        // Get the username from the Servers script
        string usernameused = Servers.currentusername;

        // Create a new WWWForm to send a request to the PHP script
        WWWForm form = new WWWForm();
        form.AddField("name", usernameused);

        // Send a request to the PHP script
        WWW www = new WWW("http://localhost/unity/Retreivalphp/mathRetreival.php", form);
        yield return www;

        // Check if the request was successful
        if (www.error != null)
        {
            Debug.Log(www.error);
            yield break;
        }

        // Split the response from the PHP script into an array of strings, using commas as the delimiter
        string[] data = www.text.Split(',');

        // Convert the appropriate array elements to strings and store them in the public static variables
        mathOverall = data[0];
        overallAverage = data[1];
        algebraAsked = data[2];
        algebraCorrect = data[3];
        arithmeticAsked = data[4];
        arithmeticCorrect = data[5];
        fdpAsked = data[6];
        fdpCorrect = data[7];

        // Log the values of the public static variables to ensure they were loaded correctly
        Debug.Log("Math Overall: " + mathOverall);
        Debug.Log("Overall Average: " + overallAverage);
        Debug.Log("Algebra Asked: " + algebraAsked);
        Debug.Log("Algebra Correct: " + algebraCorrect);
        Debug.Log("Arithmetic Asked: " + arithmeticAsked);
        Debug.Log("Arithmetic Correct: " + arithmeticCorrect);
        Debug.Log("FDP Asked: " + fdpAsked);
        Debug.Log("FDP Correct: " + fdpCorrect);
        www.Dispose();
    }
}