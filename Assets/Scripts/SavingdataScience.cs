using UnityEngine;// used by default to import basic unity functions
using UnityEngine.UI;// used to import UI and visua libraries
using System.Collections;
using UnityEngine.SceneManagement;//used to switch scene and log the user in

public class SavingdataScience : MonoBehaviour
{
    public string biologyA;
    public string chemistryA;
    public string physicsA;
    public string biologyC;
    public string chemistryC;
    public string physicsC;
    public string url;//defines url as a variable 

    // Start is called before the first frame update
    public void Start()
    {




        Debug.Log("Biology Questions Asked: " + questiongenerator.biologyAskedi);
        Debug.Log("Chemistry Questions Asked: " + questiongenerator.chemistryAskedi);
        Debug.Log("Physics Questions Asked: " + questiongenerator.physicsAskedi);
        Debug.Log("Biology Questions Correct: " + questiongenerator.biologyCorrecti);
        Debug.Log("Chemistry Questions Correct: " + questiongenerator.chemistryCorrecti);
        Debug.Log("Physics Questions Correct: " + questiongenerator.physicsCorrecti);


        biologyA = questiongenerator.biologyAskedi.ToString();
        chemistryA = questiongenerator.chemistryAskedi.ToString();
        physicsA = questiongenerator.physicsAskedi.ToString();
        //biology correct values need to be added to their existing values.
        biologyC = questiongenerator.biologyCorrecti.ToString();
        chemistryC = questiongenerator.chemistryCorrecti.ToString();
        physicsC = questiongenerator.physicsCorrecti.ToString();
        StartCoroutine(savingsciences());
        

    }

    IEnumerator savingsciences() //this will be the coroutine I will be using to update the database
    {
        WWWForm form = new WWWForm();//first create a WWW form to be parsed in
        form.AddField("name", Servers.currentusername);//passes in the currentusername as "name"

        //next  will add the string casts of the variables into the form
        form.AddField("biologyasked", biologyA);
        form.AddField("chemistryasked", chemistryA);
        form.AddField("physicsasked", physicsA);
        form.AddField("biologycorrect", biologyC);
        form.AddField("chemistrycorrect", chemistryC);
        form.AddField("physicscorrect", physicsC);

        url = "http://localhost/unity/Saving/savingScience.php";//url that will retreive
        WWW www = new WWW("http://localhost/unity/Saving/savingScience.php", form);//pass the form into the php in url
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
