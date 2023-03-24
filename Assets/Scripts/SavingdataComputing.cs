using UnityEngine;// used by default to import basic unity functions
using UnityEngine.UI;// used to import UI and visua libraries
using System.Collections;
using UnityEngine.SceneManagement;//used to switch scene and log the user in

public class SavingdataComputing : MonoBehaviour
{
    public string hardwareA;
    public string softwareA;
    public string programmingA;
    public string hardwareC;
    public string softwareC;
    public string programmingC;
    public string url;//defines url as a variable 


    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("hardware asked: " + questiongenerator.hardwareAskedi);
        Debug.Log("hardware correct: " + questiongenerator.hardwareCorrecti);
        hardwareA = questiongenerator.hardwareAskedi.ToString();
        softwareA = questiongenerator.softwareAskedi.ToString();
        programmingA = questiongenerator.programmingAskedi.ToString();
        //hardware correct values need to be added to their existing values.
        hardwareC = (questiongenerator.hardwareCorrecti).ToString();
        softwareC = (questiongenerator.softwareCorrecti).ToString();
        programmingC = (questiongenerator.programmingCorrecti).ToString();
        StartCoroutine(savingcomputings());


    }

    IEnumerator savingcomputings() //this will be the coroutine I will be using to update the database
    {
        WWWForm form = new WWWForm();//first create a WWW form to be parsed in
        form.AddField("name", Servers.currentusername);//passes in the currentusername as "name"

        //next  will add the string casts of the variables into the form
        form.AddField("hardwareasked", hardwareA);
        form.AddField("softwareasked", softwareA);
        form.AddField("programmingasked", programmingA);
        form.AddField("hardwarecorrect", hardwareC);
        form.AddField("softwarecorrect", softwareC);
        form.AddField("programmingcorrect", programmingC);

        url = "http://localhost/unity/Saving/savingComputing.php";//url that will retreive
        WWW www = new WWW("http://localhost/unity/Saving/savingComputing.php", form);//pass the form into the php in url
        yield return www;//return the response of the PHP
        if (www.text == "none")
        {
            Debug.Log("the data saved successfully");
        }
        else
        {
            Debug.Log("there was an error.");
        }
    }

}
