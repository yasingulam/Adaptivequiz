using UnityEngine;
using System.Collections;
using System;
public class csLoadStudentProgress : MonoBehaviour
{
    // Define the URL of the compretrirval file that will return the data for the specified username
    string url = "http://localhost/unity/Retreivalphp/compretreival.php";

    // Define the current user's username, which was set when they logged in in the Servers script, this will be used to locate and retreive
    string currentUsername = Servers.currentusername;

    // Define public static variables that will store the user's progress
    public static float computingOverall;
    public static float overallAverage;
    public static float hardwareAsked;
    public static float hardwareCorrect;
    public static float softwareAsked;
    public static float softwareCorrect;
    public static float programmingAsked;
    public static float programmingCorrect;


    void Start()
    {
        Debug.Log(currentUsername);
        // Send a request to the PHP file using WWW
        WWWForm form = new WWWForm();

        // Add the current user's username to the form data
        form.AddField("name", currentUsername);

        // Send the form data to the PHP file and wait for a response
        WWW www = new WWW(url, form);
        StartCoroutine(WaitForRequest(www));
    }

    // Function that will be called when the WWW request is complete
    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;
        Debug.Log(www);
        // If there was an error, log it and exit the function
        if (www.error != null)
        {
            Debug.Log("WWW Error: " + www.error);
            yield break;
        }
        else
        {
            // Split the response from the PHP file into an array of strings, using commas as the delimiter
            Debug.Log("www= " + www);
            string[] data = www.text.Split(',');
            //Debug.Log("data= "+ data);

            // Convert the appropriate array elements to floats and store them in the public static variables
            computingOverall = float.Parse(data[1]);
            overallAverage = float.Parse(data[2]);
            hardwareAsked = float.Parse(data[3]);
            hardwareCorrect = float.Parse(data[4]);
            softwareAsked = float.Parse(data[5]);
            softwareCorrect = float.Parse(data[6]);
            programmingAsked = float.Parse(data[7]);
            programmingCorrect = float.Parse(data[8]);

            // Log the values of the public static variables to ensure they were loaded correctly
            Debug.Log("Computing Overall: " + computingOverall);
            Debug.Log("Overall Average: " + overallAverage);
            Debug.Log("Hardware Asked: " + hardwareAsked);
            Debug.Log("Hardware Correct: " + hardwareCorrect);
            Debug.Log("Software Asked: " + softwareAsked);
            Debug.Log("Software Correct: " + softwareCorrect);
            Debug.Log("Programming Asked: " + programmingAsked);
            Debug.Log("Programming Correct: " + programmingCorrect);
        }
    }
}
