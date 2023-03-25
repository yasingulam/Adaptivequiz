using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //This is an imported class which I will be using for navigation
public class AnalyticsToMenu : MonoBehaviour
{
    public string scene;//add name of scene 
    public Color loadToColor = Color.black;

    public void returnanalytics()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Initiate.Fade(scene, loadToColor, 2.3f);
    }

}

