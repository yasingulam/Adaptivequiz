using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //This is an imported class which I will be using for navigation

public class QuiztoAnalytics : MonoBehaviour
{


    public void quiztoanalytics()
    {
        //makes the option menu so thaat the saving script knows where to go after
        SavingScriptDecider.option = "menu";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
