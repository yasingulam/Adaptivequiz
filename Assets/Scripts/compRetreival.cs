using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compRetreival : MonoBehaviour
{
    // Define public static variables that will store the user's progress
    public static string computingOverall;
    public static string overallAverage;
    public static string hardwareAsked;
    public static string hardwareCorrect;
    public static string softwareAsked;
    public static string softwareCorrect;
    public static string programmingAsked;
    public static string programmingCorrect;

    void Start()
    {
        // Call the coroutine to retrieve the user's progress
        StartCoroutine(computingRetrieval());
    }

    public static IEnumerator computingRetrieval()
    {
        // Get the username from the Servers script
        string usernameused = Servers.currentusername;

        // Create a new WWWForm to send a request to the PHP script
        WWWForm form = new WWWForm();
        form.AddField("name", usernameused);

        // Send a request to the PHP script
        WWW www = new WWW("http://localhost/unity/Retreivalphp/compretreival.php", form);
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
        computingOverall = data[0];
        overallAverage = data[1];
        hardwareAsked = data[2];
        hardwareCorrect = data[3];
        softwareAsked = data[4];
        softwareCorrect = data[5];
        programmingAsked = data[6];
        programmingCorrect = data[7];

        // Log the values of the public static variables to ensure they were loaded correctly
        Debug.Log("Computing Overall: " + computingOverall);
        Debug.Log("Overall Average: " + overallAverage);
        Debug.Log("Hardware Asked: " + hardwareAsked);
        Debug.Log("Hardware Correct: " + hardwareCorrect);
        Debug.Log("Software Asked: " + softwareAsked);
        Debug.Log("Software Correct: " + softwareCorrect);
        Debug.Log("Programming Asked: " + programmingAsked);
        Debug.Log("Programming Correct: " + programmingCorrect);

        www.Dispose();
    }
}