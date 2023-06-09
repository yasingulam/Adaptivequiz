using UnityEngine;// used by default to import basic unity functions
using UnityEngine.UI;// used to import UI and visual libraries
using System.Collections;
using UnityEngine.SceneManagement;//used to switch scene and log the user in

public class TeacherLogin : MonoBehaviour

{
    public string scene;//add name of scene 
    public Color loadToColor = Color.black;
    public InputField inputField;
    public int pin = 123456;
    
    public Text errorMessage;
    public Button loginButton;

    private void Start()
    {
        loginButton.onClick.AddListener(CheckPin);
    }

    public void CheckPin()
    {
        if (inputField.text == pin.ToString())
        {
            Initiate.Fade(scene, loadToColor, 2.3f);//new change in scene function

        }
        else
        {
            errorMessage.text = "Invalid Pin";
        }

    }
}