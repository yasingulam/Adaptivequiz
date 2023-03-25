using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //This is an imported class which I will be using for navigation

public class SavingScriptDecider : MonoBehaviour
{
    public string analyticsscene;//add name of scene 
    public string menuscene;//add name of scene 
    //2 scenes needed
    public Color loadToColor = Color.black;

    public static string option;
    // Get the value of parsedsubject from the beginQuiz script
    string parsedsubject = beginQuiz.parsedsubject;

    // This method is called when the script is first loaded
    public void Start()
    {
        StartCoroutine(chosingsavesubject());
    }
    IEnumerator chosingsavesubject()
    {

        // If the parsedsubject is "maths", add the SavingdataMaths script to the gameObject and start it
        if (parsedsubject == "maths")
        {
            SavingdataMaths loader = gameObject.AddComponent<SavingdataMaths>();
            loader.Start();
            yield return new WaitForSeconds(3.4f);
            if (option == "analytics")
            {
                Initiate.Fade(analyticsscene, loadToColor, 2.3f);
            }
            else//Could go to either analytics or menu
            {
                Initiate.Fade(menuscene, loadToColor, 2.3f);
            }
        }



        // If the parsedsubject is "science", add the SavingdataScience script to the gameObject and start it
        else if (parsedsubject == "science")
        {
            SavingdataScience loader = gameObject.AddComponent<SavingdataScience>();
            loader.Start();
            yield return new WaitForSeconds(3.4f);
            if (option == "analytics")
            {
                Initiate.Fade(analyticsscene, loadToColor, 2.3f);
            }
            else
            {
                Initiate.Fade(menuscene, loadToColor, 2.3f);
            }


        }
        else if (parsedsubject == "computing")
        {
            SavingdataComputing loader = gameObject.AddComponent<SavingdataComputing>();
            loader.Start();
            yield return new WaitForSeconds(3.4f);
            if (option == "analytics")
            {
                Initiate.Fade(analyticsscene, loadToColor, 2.3f);
            }
            else
            {
                Initiate.Fade(menuscene, loadToColor, 2.3f);
            }
        }





        // If the parsedsubject is neither "maths" nor "science", log an error message to the console
        else
        {
            Debug.LogError("Invalid subject: " + parsedsubject);

        }
    }
}