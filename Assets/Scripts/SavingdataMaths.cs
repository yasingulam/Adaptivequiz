using UnityEngine;// used by default to import basic unity functions
using UnityEngine.UI;// used to import UI and visua libraries
using System.Collections;
using UnityEngine.SceneManagement;//used to switch scene and log the user in

public class SavingdataMaths : MonoBehaviour
{
    public string algebraA;
    public string arithmeticA;
    public string fdpA;
    public string algebraC;
    public string arithmeticC;
    public string fdpC;
    public string url;//defines url as a variable 

    // Start is called before the first frame update
    public void Start()
    {

        Debug.Log("Algebra Questions Asked: " + questiongenerator.algebraAskedi);
        Debug.Log("Arithmetic Questions Asked: " + questiongenerator.arithmeticAskedi);
        Debug.Log("FDP Questions Asked: " + questiongenerator.fdpAskedi);
        Debug.Log("Algebra Questions Correct: " + questiongenerator.algebraCorrecti);
        Debug.Log("Arithmetic Questions Correct: " + questiongenerator.arithmeticCorrecti);
        Debug.Log("FDP Questions Correct: " + questiongenerator.fdpCorrecti);

        algebraA = questiongenerator.algebraAskedi.ToString();
        arithmeticA = questiongenerator.arithmeticAskedi.ToString();
        fdpA = questiongenerator.fdpAskedi.ToString();
        //algebra correct values need to be added to their existing values.
        algebraC = (questiongenerator.algebraCorrecti).ToString();
        arithmeticC = (questiongenerator.arithmeticCorrecti).ToString();
        fdpC = (questiongenerator.fdpCorrecti).ToString();
        StartCoroutine(savingmaths());


    }

    IEnumerator savingmaths() //this will be the coroutine I will be using to update the database
    {
        WWWForm form = new WWWForm();//first create a WWW form to be parsed in
        form.AddField("name", Servers.currentusername);//passes in the currentusername as "name"
       
        //next  will add the string casts of the variables into the form
        form.AddField("algebraasked", algebraA);
        form.AddField("arithmeticasked", arithmeticA);
        form.AddField("fdpasked", fdpA);
        form.AddField("algebracorrect", algebraC);
        form.AddField("arithmeticcorrect", arithmeticC);
        form.AddField("fdpcorrect", fdpC);

        url = "http://localhost/unity/Saving/savingMaths.php";//url that will retreive
        WWW www = new WWW("http://localhost/unity/Saving/savingMaths.php", form);//pass the form into the php in url
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
