using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;// the timer is using textmeshpro

public class questionoutput : MonoBehaviour
{
    public GameObject screenquestion;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;
    public GameObject showntopic;
    public static string displayedtopic;
    public static string nextquestion;
    public static string nextanswer1;
    public static string nextanswer2;
    public static string nextanswer3;
    public static string nextanswer4;
    public static bool updates = false;//defaults to false


    public static int integerTimes;
    public TextMeshProUGUI timertext;
    public float times;
    public bool countDown;
    /// created the 4 variables to hold the questions and answers.


    void Update()
    {
        times = countDown ? times -= Time.deltaTime : times += Time.deltaTime; //if timer on then add if off then nothing
        integerTimes = Mathf.RoundToInt(times); //convert to integer using Mathf.RoundToInt()
        timertext.text = "Time: "+integerTimes.ToString(); //convert to string so can be displayed.
        if (questiongenerator.questionnumber == 31)
        {
            countDown = false; //stop the timer
        }


        if (updates == false)
        {
            updates = true;//turns off the default so the coroutine can start- quiz has started
            StartCoroutine(displaytextonscreen());

        }
    }
    IEnumerator displaytextonscreen()
    {
        yield return new WaitForSeconds(0.1f);//wait for 0.1 before moving on
        //attach to their corresponding UI elements 
        screenquestion.GetComponent<Text>().text = nextquestion;
        answer1.GetComponent<Text>().text = nextanswer1;
        answer2.GetComponent<Text>().text = nextanswer2;
        answer3.GetComponent<Text>().text = nextanswer3;
        answer4.GetComponent<Text>().text = nextanswer4;
        showntopic.GetComponent<Text>().text = displayedtopic;

    }
}
