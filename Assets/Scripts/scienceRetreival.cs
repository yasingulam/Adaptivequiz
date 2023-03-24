using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scienceRetreival : MonoBehaviour
{
    // Define public static variables that will store the user's progress
    public static string scienceOverall;
    public static string overallAverage;
    public static string biologyAsked;
    public static string biologyCorrect;
    public static string chemistryAsked;
    public static string chemistryCorrect;
    public static string physicsAsked;
    public static string physicsCorrect;

    void Start()
    {
        // Call the coroutine to retrieve the user's progress
        StartCoroutine(ScienceRetrievalCoroutine());
    }

    IEnumerator ScienceRetrievalCoroutine()
    {
        // Get the username from the Servers script
        string usernameUsed = Servers.currentusername;

        // Create a new WWWForm to send a request to the PHP script
        WWWForm form = new WWWForm();
        form.AddField("name", usernameUsed);

        // Send a request to the PHP script
        WWW www = new WWW("http://localhost/unity/Retreivalphp/scienceRetreival.php", form);
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
        scienceOverall = data[0];
        overallAverage = data[1];
        biologyAsked = data[2];
        biologyCorrect = data[3];
        chemistryAsked = data[4];
        chemistryCorrect = data[5];
        physicsAsked = data[6];
        physicsCorrect = data[7];

        // Log the values of the public static variables to ensure they were loaded correctly
        Debug.Log("Science Overall: " + scienceOverall);
        Debug.Log("Overall Average: " + overallAverage);
        Debug.Log("Biology Asked: " + biologyAsked);
        Debug.Log("Biology Correct: " + biologyCorrect);
        Debug.Log("Chemistry Asked: " + chemistryAsked);
        Debug.Log("Chemistry Correct: " + chemistryCorrect);
        Debug.Log("Physics Asked: " + physicsAsked);
        Debug.Log("Physics Correct: " + physicsCorrect);
        www.Dispose();
        
    }
}
