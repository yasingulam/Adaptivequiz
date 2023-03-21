using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //This is an imported class which I will be using for navigation

public class ScriptDecider : MonoBehaviour
{
    // Get the value of parsedsubject from the beginQuiz script
    string parsedsubject = beginQuiz.parsedsubject;

    // This method is called when the script is first loaded
    public void Start()
    {
        StartCoroutine(loadingquestions());
    }
    IEnumerator loadingquestions()
    {
        
        // If the parsedsubject is "maths", add the QuestionLoaderMaths script to the gameObject and start it
        if (parsedsubject == "maths")
        {
            QuestionLoaderMaths loader = gameObject.AddComponent<QuestionLoaderMaths>();
            loader.Start();
            yield return new WaitForSeconds(3.4f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // If the parsedsubject is "science", add the QuestionLoaderScience script to the gameObject and start it
        else if (parsedsubject == "science")
        {
            QuestionLoaderScience loader = gameObject.AddComponent<QuestionLoaderScience>();
            loader.Start();
            yield return new WaitForSeconds(3.4f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (parsedsubject == "computing")
        {
            QuestionLoaderComputing loader = gameObject.AddComponent<QuestionLoaderComputing>();
            loader.Start();
            yield return new WaitForSeconds(3.4f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // If the parsedsubject is neither "maths" nor "science", log an error message to the console
        else
        {
            Debug.LogError("Invalid subject: " + parsedsubject);

        }
    }
}