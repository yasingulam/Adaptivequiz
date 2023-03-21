using UnityEngine;// used by default to import basic unity functions
using UnityEngine.UI;// used to import UI and visua libraries
using System.Collections;
using UnityEngine.SceneManagement;//used to switch scene and log the user in
public class Servers : MonoBehaviour


{
    public static string currentusername;// defines variable as a global variable(currentusername) to be used for various reasons in different scripts


    [Space]
    [SerializeField] InputField username;
    [SerializeField] InputField password;

    [SerializeField] Text errormessage; 
    [SerializeField] Text successmessage;


    [SerializeField] Button loginButton;


    [SerializeField] string url;
    //serializing all the field so that they can be converted into data which can be processed by a script
    WWWForm form;// creates a form in the name WWWform

    public void OnLoginButtonClicked()//creates a function which begins the login process
    {//this will be attached to the login button and will carry out when its pressd
        loginButton.interactable = false;
        //temporarily disables the login button so that thereisnt multiple requests
        StartCoroutine(Login());
    }
   

    IEnumerator Login() //starts the login subroutine
    {
        form = new WWWForm();//defines the WWWFormw which was previously created

        form.AddField("username", username.text);
        form.AddField("password", password.text);
        // adds the two input fields to a data structure (array) known as a form
        WWW w = new WWW(url, form);
        yield return w;

        if (w.error != null)
        {
            errormessage.text = "404 not found!";
            Debug.Log("<color=red>" + w.text + "</color>");//error
        }
        else
        {
            if (w.isDone)
            {
                if (w.text.Contains("error"))
                {
                    errormessage.text = "invalid username or password!";
                    Debug.Log("<color=red>" + w.text + "</color>");//error
                }
                else
                {
                    //Success
                    successmessage.text = "valid username or password!";
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    errormessage.text = "";
                    Servers.currentusername = username.text;



                }
            }
        }

        loginButton.interactable = true;
     

        w.Dispose();
    }
}