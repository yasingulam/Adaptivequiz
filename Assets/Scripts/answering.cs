using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answering : MonoBehaviour
{
    // These public GameObjects represent the different states of the answer: neutral, correct, and incorrect.
    public GameObject answer1blue;   // neutral, no answer
    public GameObject answer1green;  // correct
    public GameObject answer1red;    // incorrect
    public GameObject answer2blue;   // neutral, no answer
    public GameObject answer2green;  // correct
    public GameObject answer2red;    // incorrect
    public GameObject answer3blue;   // neutral, no answer
    public GameObject answer3green;  // correct
    public GameObject answer3red;    // incorrect
    public GameObject answer4blue;   // neutral, no answer
    public GameObject answer4green;  // correct
    public GameObject answer4red;    // incorrect
    public GameObject questioncount; 
    public GameObject answer1button;
    public GameObject answer2button;
    public GameObject answer3button;
    public GameObject answer4button;




    public AudioSource correctSound;
    public AudioSource incorrectSound1;
    public AudioSource incorrectSound2;
    public AudioSource incorrectSound3;
    // This method is called when the answer is clicked on.


    public int questionnum;
    public static int topic1correct;
    public static int topic2correct;
    public static int topic3correct;

    void Start()
    {
        questionnum = 1;
        topic1correct = 0;
        topic2correct = 0;
        topic3correct = 0;

    }
    void Update() 
    {
        questioncount.GetComponent<Text>().text = "Question: " + questionnum;

    }

    public void answer1()
    {
        // Print the correct answer and the answer clicked on to the console for debugging purposes.
        Debug.Log(questiongenerator.correctans);
        Debug.Log(questionoutput.nextanswer1);

        // If the clicked answer matches the correct answer, set the "neutral" GameObject to inactive and the "correct" GameObject to active.
        if (questiongenerator.correctans == questionoutput.nextanswer1)
        {
            answer1blue.SetActive(false);
            answer1green.SetActive(true);
            answer1red.SetActive(false);
            correctSound.Play();
 
            if ((questionoutput.displayedtopic == "biology") ||(questionoutput.displayedtopic == "algebra") ||(questionoutput.displayedtopic == "hardware"))//checks if its the topic 1s 
            {
                topic1correct++;
            }
            if ((questionoutput.displayedtopic == "chemistry") || (questionoutput.displayedtopic == "arithmetic") || (questionoutput.displayedtopic == "software"))//checks if its the topic 2s 
            {
                topic2correct++;
            }
            if ((questionoutput.displayedtopic == "physics") || (questionoutput.displayedtopic == "FDP") || (questionoutput.displayedtopic == "programming"))//checks if its the topic 1s 
            {
                topic3correct++;
            }




        }
        else
        {
            answer1blue.SetActive(false);
            answer1green.SetActive(false);
            answer1red.SetActive(true);
            incorrectSound1.Play();
     


        }
        //disable all the buttons to prevent double click
        answer1button.GetComponent<Button>().enabled = false;
        answer2button.GetComponent<Button>().enabled = false;
        answer3button.GetComponent<Button>().enabled = false;
        answer4button.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());


    }
    public void answer2()
    {
        // Print the correct answer and the answer clicked on to the console for debugging purposes.
        Debug.Log(questiongenerator.correctans);
        Debug.Log(questionoutput.nextanswer2);

        // If the clicked answer matches the correct answer, set the "neutral" GameObject to inactive and the "correct" GameObject to active.
        if (questiongenerator.correctans == questionoutput.nextanswer2)
        {
            answer2blue.SetActive(false);
            answer2green.SetActive(true);
            answer2red.SetActive(false);
            correctSound.Play();
            if ((questionoutput.displayedtopic == "biology") ||(questionoutput.displayedtopic == "algebra") ||(questionoutput.displayedtopic == "hardware"))//checks if its the topic 1s 
            {
                topic1correct++;
            }
            if ((questionoutput.displayedtopic == "chemistry") || (questionoutput.displayedtopic == "arithmetic") || (questionoutput.displayedtopic == "software"))//checks if its the topic 2s 
            {
                topic2correct++;
            }
            if ((questionoutput.displayedtopic == "physics")||(questionoutput.displayedtopic == "FDP")||(questionoutput.displayedtopic == "programming"))//checks if its the topic 1s 
            {
                topic3correct++;
            }
        }
        else
        {
            answer2blue.SetActive(false);
            answer2green.SetActive(false);
            answer2red.SetActive(true);
            incorrectSound1.Play();
   


        }
        //disable all the buttons to prevent double click
        answer1button.GetComponent<Button>().enabled = false;
        answer2button.GetComponent<Button>().enabled = false;
        answer3button.GetComponent<Button>().enabled = false;
        answer4button.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void answer3()
    {
        // Print the correct answer and the answer clicked on to the console for debugging purposes.
        Debug.Log(questiongenerator.correctans);
        Debug.Log(questionoutput.nextanswer3);

        // If the clicked answer matches the correct answer, set the "neutral" GameObject to inactive and the "correct" GameObject to active.
        if (questiongenerator.correctans == questionoutput.nextanswer3)
        {
            answer3blue.SetActive(false);
            answer3green.SetActive(true);
            answer3red.SetActive(false);
            correctSound.Play();

            if ((questionoutput.displayedtopic == "biology") ||(questionoutput.displayedtopic == "algebra") ||(questionoutput.displayedtopic == "hardware"))//checks if its the topic 1s 
            {
                topic1correct += 1;
            }
            if ((questionoutput.displayedtopic == "chemistry") || (questionoutput.displayedtopic == "arithmetic") || (questionoutput.displayedtopic == "software"))//checks if its the topic 2s 
            {
                topic2correct += 1;
            }
            if ((questionoutput.displayedtopic == "physics") || (questionoutput.displayedtopic == "FDP") || (questionoutput.displayedtopic == "programming"))//checks if its the topic 1s 
            {
                topic3correct += 1;
            }
        }
        else
        {
            answer3blue.SetActive(false);
            answer3green.SetActive(false);
            answer3red.SetActive(true);
            incorrectSound2.Play();



        }
        //disable all the buttons to prevent double click
        answer1button.GetComponent<Button>().enabled = false;
        answer2button.GetComponent<Button>().enabled = false;
        answer3button.GetComponent<Button>().enabled = false;
        answer4button.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }
    public void answer4()
    {
        // Print the correct answer and the answer clicked on to the console for debugging purposes.
        Debug.Log(questiongenerator.correctans);
        Debug.Log(questionoutput.nextanswer4);

        // If the clicked answer matches the correct answer, set the "neutral" GameObject to inactive and the "correct" GameObject to active.
        if (questiongenerator.correctans == questionoutput.nextanswer4)
        {
            answer4blue.SetActive(false);
            answer4green.SetActive(true);
            answer4red.SetActive(false);
            correctSound.Play();

            if ((questionoutput.displayedtopic == "biology") ||(questionoutput.displayedtopic == "algebra") ||(questionoutput.displayedtopic == "hardware"))//checks if its the topic 1s 
            {
                topic1correct += 1;
            }
            if ((questionoutput.displayedtopic == "chemistry") || (questionoutput.displayedtopic == "arithmetic") || (questionoutput.displayedtopic == "software"))//checks if its the topic 2s 
            {
                topic2correct += 1;
            }
            if ((questionoutput.displayedtopic == "physics") || (questionoutput.displayedtopic == "FDP") || (questionoutput.displayedtopic == "programming"))//checks if its the topic 1s 
            {
                topic3correct += 1;
            }
        }
        else
        {
            answer4blue.SetActive(false);
            answer4green.SetActive(false);
            answer4red.SetActive(true);
            incorrectSound3.Play();
      



        }
        //disable all the buttons to prevent double click
        answer1button.GetComponent<Button>().enabled = false;
        answer2button.GetComponent<Button>().enabled = false;
        answer3button.GetComponent<Button>().enabled = false;
        answer4button.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion() 
    {
        yield return new WaitForSeconds(2.1f);//wait for two before moving on




        //set colours back to their original values and make buttons clickable again
        answer1blue.SetActive(true);
        answer1green.SetActive(false);
        answer1red.SetActive(false);
        answer2blue.SetActive(true);
        answer2green.SetActive(false);
        answer2red.SetActive(false);
        answer3blue.SetActive(true);
        answer3green.SetActive(false);
        answer3red.SetActive(false);
        answer4blue.SetActive(true);
        answer4green.SetActive(false);
        answer4red.SetActive(false);
        answer1button.GetComponent<Button>().enabled = true;
        answer2button.GetComponent<Button>().enabled = true;
        answer3button.GetComponent<Button>().enabled = true;
        answer4button.GetComponent<Button>().enabled = true;
        questiongenerator.questionnumber++;
        questionnum++;
        questionoutput.updates = false;
        questiongenerator.questiondisplayed = false;//triggers the new question
        Debug.Log(questiongenerator.questionnumber);

    }





    }