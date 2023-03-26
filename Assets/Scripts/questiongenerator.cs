using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class questiongenerator : MonoBehaviour
{




    public static string[] question1 = new string[8];
    public static string[] question2 = new string[8];
    public static string[] question3 = new string[8];
    public static string[] question4 = new string[8];
    public static string[] question5 = new string[8];
    public static string[] question6 = new string[8];
    public static string[] question7 = new string[8];
    public static string[] question8 = new string[8];
    public static string[] question9 = new string[8];
    public static string[] question10 = new string[8];
    public static string[] question11 = new string[8];
    public static string[] question12 = new string[8];
    public static string[] question13 = new string[8];
    public static string[] question14 = new string[8];
    public static string[] question15 = new string[8];
    public static string[] question16 = new string[8];
    public static string[] question17 = new string[8];
    public static string[] question18 = new string[8];
    public static string[] question19 = new string[8];
    public static string[] question20 = new string[8];
    public static string[] question21 = new string[8];
    public static string[] question22 = new string[8];
    public static string[] question23 = new string[8];
    public static string[] question24 = new string[8];
    public static string[] question25 = new string[8];
    public static string[] question26 = new string[8];
    public static string[] question27 = new string[8];
    public static string[] question28 = new string[8];
    public static string[] question29 = new string[8];
    public static string[] question30 = new string[8];

    public GameObject panel;//this is for the end window
    public GameObject timetakenend;
    public GameObject questionscorrect;
    public GameObject correctpercentage;
    public GameObject mainmenubutton;
    public GameObject backtoanalyticsbutton;


    //used to calculate %correct at the end
    public int totalmathsscore;
    public int totalsciencescore;
    public int totalcomputingscore;
    public int percentagescore;

    public static string correctans; // defining the correct answer into a variable
    public static bool questiondisplayed;//there is no question currently set
    public static int questionnumber;//what is the current number?
    public string questiontopic;// what is the topic

    // for the end part
    public static int algebraAskedi;
    public static int arithmeticAskedi;
    public static int fdpAskedi;
    public static int algebraCorrecti;
    public static int arithmeticCorrecti;
    public static int fdpCorrecti;
    public static int biologyAskedi;
    public static int chemistryAskedi;
    public static int physicsAskedi;
    public static int biologyCorrecti;
    public static int chemistryCorrecti;
    public static int physicsCorrecti;
    public static int hardwareAskedi;
    public static int softwareAskedi;
    public static int programmingAskedi;
    public static int hardwareCorrecti;
    public static int softwareCorrecti;
    public static int programmingCorrecti;





    // Start is called before the first frame update
    void Start()
    {
        questionoutput.updates = false;
        panel.SetActive(false);//makes sure the window is not active

        if (beginQuiz.parsedsubject == "maths")
        {
            question1 = QuestionLoaderMaths.question1;
            question2 = QuestionLoaderMaths.question2;
            question3 = QuestionLoaderMaths.question3;
            question4 = QuestionLoaderMaths.question4;
            question5 = QuestionLoaderMaths.question5;
            question6 = QuestionLoaderMaths.question6;
            question7 = QuestionLoaderMaths.question7;
            question8 = QuestionLoaderMaths.question8;
            question9 = QuestionLoaderMaths.question9;
            question10 = QuestionLoaderMaths.question10;
            question11 = QuestionLoaderMaths.question11;
            question12 = QuestionLoaderMaths.question12;
            question13 = QuestionLoaderMaths.question13;
            question14 = QuestionLoaderMaths.question14;
            question15 = QuestionLoaderMaths.question15;
            question16 = QuestionLoaderMaths.question16;
            question17 = QuestionLoaderMaths.question17;
            question18 = QuestionLoaderMaths.question18;
            question19 = QuestionLoaderMaths.question19;
            question20 = QuestionLoaderMaths.question20;
            question21 = QuestionLoaderMaths.question21;
            question22 = QuestionLoaderMaths.question22;
            question23 = QuestionLoaderMaths.question23;
            question24 = QuestionLoaderMaths.question24;
            question25 = QuestionLoaderMaths.question25;
            question26 = QuestionLoaderMaths.question26;
            question27 = QuestionLoaderMaths.question27;
            question28 = QuestionLoaderMaths.question28;
            question29 = QuestionLoaderMaths.question29;
            question30 = QuestionLoaderMaths.question30;
        }


        if (beginQuiz.parsedsubject == "science")
        {

            question1 = QuestionLoaderScience.question1;
            question2 = QuestionLoaderScience.question2;
            question3 = QuestionLoaderScience.question3;
            question4 = QuestionLoaderScience.question4;
            question5 = QuestionLoaderScience.question5;
            question6 = QuestionLoaderScience.question6;
            question7 = QuestionLoaderScience.question7;
            question8 = QuestionLoaderScience.question8;
            question9 = QuestionLoaderScience.question9;
            question10 = QuestionLoaderScience.question10;
            question11 = QuestionLoaderScience.question11;
            question12 = QuestionLoaderScience.question12;
            question13 = QuestionLoaderScience.question13;
            question14 = QuestionLoaderScience.question14;
            question15 = QuestionLoaderScience.question15;
            question16 = QuestionLoaderScience.question16;
            question17 = QuestionLoaderScience.question17;
            question18 = QuestionLoaderScience.question18;
            question19 = QuestionLoaderScience.question19;
            question20 = QuestionLoaderScience.question20;
            question21 = QuestionLoaderScience.question21;
            question22 = QuestionLoaderScience.question22;
            question23 = QuestionLoaderScience.question23;
            question24 = QuestionLoaderScience.question24;
            question25 = QuestionLoaderScience.question25;
            question26 = QuestionLoaderScience.question26;
            question27 = QuestionLoaderScience.question27;
            question28 = QuestionLoaderScience.question28;
            question29 = QuestionLoaderScience.question29;
            question30 = QuestionLoaderScience.question30;
        }
        if (beginQuiz.parsedsubject == "computing")
        {
            question1 = QuestionLoaderComputing.question1;
            question2 = QuestionLoaderComputing.question2;
            question3 = QuestionLoaderComputing.question3;
            question4 = QuestionLoaderComputing.question4;
            question5 = QuestionLoaderComputing.question5;
            question6 = QuestionLoaderComputing.question6;
            question7 = QuestionLoaderComputing.question7;
            question8 = QuestionLoaderComputing.question8;
            question9 = QuestionLoaderComputing.question9;
            question10 = QuestionLoaderComputing.question10;
            question11 = QuestionLoaderComputing.question11;
            question12 = QuestionLoaderComputing.question12;
            question13 = QuestionLoaderComputing.question13;
            question14 = QuestionLoaderComputing.question14;
            question15 = QuestionLoaderComputing.question15;
            question16 = QuestionLoaderComputing.question16;
            question17 = QuestionLoaderComputing.question17;
            question18 = QuestionLoaderComputing.question18;
            question19 = QuestionLoaderComputing.question19;
            question20 = QuestionLoaderComputing.question20;
            question21 = QuestionLoaderComputing.question21;
            question22 = QuestionLoaderComputing.question22;
            question23 = QuestionLoaderComputing.question23;
            question24 = QuestionLoaderComputing.question24;
            question25 = QuestionLoaderComputing.question25;
            question26 = QuestionLoaderComputing.question26;
            question27 = QuestionLoaderComputing.question27;
            question28 = QuestionLoaderComputing.question28;
            question29 = QuestionLoaderComputing.question29;
            question30 = QuestionLoaderComputing.question30;
        }
        Debug.Log(question20[0]);



    }
    






    // Update is called once per frame
    void Update()
    {
        //Debug.Log(beginQuiz.parsedsubject);
        enabled = true;
        


        if (questiondisplayed == false) //checks if there is a question being displayed
        {
            if (questionnumber == 0)
            {
                questionnumber++;
            }

            if (questionnumber == 1)
            {
                                         //taking the next question variables from the previous script
                questionoutput.nextquestion = question1[0];
                questionoutput.nextanswer1 = question1[3];
                questionoutput.nextanswer2 = question1[2];
                questionoutput.nextanswer3 = question1[1];
                questionoutput.nextanswer4 = question1[4];

                correctans = question1[5]; // setting the correct answer variable to "option 1 test"
                questionoutput.displayedtopic = question1[7];
            }
            if (questionnumber == 2)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question2[0];
                questionoutput.nextanswer1 = question2[2];
                questionoutput.nextanswer2 = question2[1];
                questionoutput.nextanswer3 = question2[3];
                questionoutput.nextanswer4 = question2[4];
                correctans = question2[5];
                questionoutput.displayedtopic = question2[7];
            }
            if (questionnumber == 3)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question3[0];
                questionoutput.nextanswer1 = question3[4];
                questionoutput.nextanswer2 = question3[2];
                questionoutput.nextanswer3 = question3[3];
                questionoutput.nextanswer4 = question3[1];
                correctans = question3[5];
                questionoutput.displayedtopic = question3[7];
            }
            if (questionnumber == 4)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question4[0];
                questionoutput.nextanswer1 = question4[2];
                questionoutput.nextanswer2 = question4[1];
                questionoutput.nextanswer3 = question4[4];
                questionoutput.nextanswer4 = question4[3];
                correctans = question4[5];
                questionoutput.displayedtopic = question4[7];
            }
            if (questionnumber == 5)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question5[0];
                questionoutput.nextanswer1 = question5[2];
                questionoutput.nextanswer2 = question5[4];
                questionoutput.nextanswer3 = question5[1];
                questionoutput.nextanswer4 = question5[3];
                correctans = question5[5];
                questionoutput.displayedtopic = question5[7];
            }
            if (questionnumber == 6)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question6[0];
                questionoutput.nextanswer1 = question6[1];
                questionoutput.nextanswer2 = question6[2];
                questionoutput.nextanswer3 = question6[3];
                questionoutput.nextanswer4 = question6[4];
                correctans = question6[5];
                questionoutput.displayedtopic = question6[7];
            }
            if (questionnumber == 7)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question7[0];
                questionoutput.nextanswer1 = question7[3];
                questionoutput.nextanswer2 = question7[4];
                questionoutput.nextanswer3 = question7[2];
                questionoutput.nextanswer4 = question7[1];
                correctans = question7[5];
                questionoutput.displayedtopic = question7[7];
            }
            if (questionnumber == 8)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question8[0];
                questionoutput.nextanswer1 = question8[4];
                questionoutput.nextanswer2 = question8[2];
                questionoutput.nextanswer3 = question8[3];
                questionoutput.nextanswer4 = question8[1];
                correctans = question8[5];
                questionoutput.displayedtopic = question8[7];
            }
            if (questionnumber == 9)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question9[0];
                questionoutput.nextanswer1 = question9[2];
                questionoutput.nextanswer2 = question9[3];
                questionoutput.nextanswer3 = question9[1];
                questionoutput.nextanswer4 = question9[4];
                correctans = question9[5];
                questionoutput.displayedtopic = question9[7];
            }
            if (questionnumber == 10)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question10[0];
                questionoutput.nextanswer1 = question10[3];
                questionoutput.nextanswer2 = question10[2];
                questionoutput.nextanswer3 = question10[1];
                questionoutput.nextanswer4 = question10[4];
                correctans = question10[5];
                questionoutput.displayedtopic = question10[7];
            }
            if (questionnumber == 11)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question11[0];
                questionoutput.nextanswer1 = question11[2];
                questionoutput.nextanswer2 = question11[1];
                questionoutput.nextanswer3 = question11[3];
                questionoutput.nextanswer4 = question11[4];
                correctans = question11[5];
                questionoutput.displayedtopic = question11[7];
            }
            if (questionnumber == 12)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question12[0];
                questionoutput.nextanswer1 = question12[4];
                questionoutput.nextanswer2 = question12[2];
                questionoutput.nextanswer3 = question12[3];
                questionoutput.nextanswer4 = question12[1];
                correctans = question12[5];
                questionoutput.displayedtopic = question12[7];
            }
            if (questionnumber == 13)
            {
                
                questionoutput.nextquestion = question13[0];
                questionoutput.nextanswer1 = question13[3];
                questionoutput.nextanswer2 = question13[2];
                questionoutput.nextanswer3 = question13[1];
                questionoutput.nextanswer4 = question13[4];
                correctans = question13[5];
                questionoutput.displayedtopic = question13[7];
            }
            if (questionnumber == 14)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question14[0];
                questionoutput.nextanswer1 = question14[3];
                questionoutput.nextanswer2 = question14[4];
                questionoutput.nextanswer3 = question14[1];
                questionoutput.nextanswer4 = question14[2];
                correctans = question14[5];
                questionoutput.displayedtopic = question14[7];
            }
            if (questionnumber == 15)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question15[0];
                questionoutput.nextanswer1 = question15[1];
                questionoutput.nextanswer2 = question15[2];
                questionoutput.nextanswer3 = question15[3];
                questionoutput.nextanswer4 = question15[4];
                correctans = question15[5];
                questionoutput.displayedtopic = question15[7];
            }
            if (questionnumber == 16)
            {
                
                questionoutput.nextquestion = question16[0];
                questionoutput.nextanswer1 = question16[2];
                questionoutput.nextanswer2 = question16[4];
                questionoutput.nextanswer3 = question16[3];
                questionoutput.nextanswer4 = question16[1];
                correctans = question16[5];
                questionoutput.displayedtopic = question16[7];
            }
            if (questionnumber == 17)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question17[0];
                questionoutput.nextanswer1 = question17[1];
                questionoutput.nextanswer2 = question17[2];
                questionoutput.nextanswer3 = question17[3];
                questionoutput.nextanswer4 = question17[4];
                correctans = question17[5];
                questionoutput.displayedtopic = question17[7];
            }
            if (questionnumber == 18)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question18[0];
                questionoutput.nextanswer1 = question18[4];
                questionoutput.nextanswer2 = question18[3];
                questionoutput.nextanswer3 = question18[2];
                questionoutput.nextanswer4 = question18[1];
                correctans = question18[5];
                questionoutput.displayedtopic = question18[7];
            }
            if (questionnumber == 18)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question18[0];
                questionoutput.nextanswer1 = question18[3];
                questionoutput.nextanswer2 = question18[2];
                questionoutput.nextanswer3 = question18[1];
                questionoutput.nextanswer4 = question18[4];
                correctans = question18[5];
                questionoutput.displayedtopic = question18[7];
            }
            if (questionnumber == 19)
            {
                
                questionoutput.nextquestion = question19[0];
                questionoutput.nextanswer1 = question19[2];
                questionoutput.nextanswer2 = question19[1];
                questionoutput.nextanswer3 = question19[3];
                questionoutput.nextanswer4 = question19[4];
                correctans = question19[5];
                questionoutput.displayedtopic = question19[7];
            }
            if (questionnumber == 20)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question20[0];
                questionoutput.nextanswer1 = question20[4];
                questionoutput.nextanswer2 = question20[2];
                questionoutput.nextanswer3 = question20[1];
                questionoutput.nextanswer4 = question20[3];
                correctans = question20[5];
                questionoutput.displayedtopic = question20[7];
            }
            if (questionnumber == 21)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question21[0];
                questionoutput.nextanswer1 = question21[2];
                questionoutput.nextanswer2 = question21[1];
                questionoutput.nextanswer3 = question21[4];
                questionoutput.nextanswer4 = question21[2];
                correctans = question21[5];
                questionoutput.displayedtopic = question21[7];
            }
            if (questionnumber == 22)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question22[0];
                questionoutput.nextanswer1 = question22[2];
                questionoutput.nextanswer2 = question22[4];
                questionoutput.nextanswer3 = question22[3];
                questionoutput.nextanswer4 = question22[1];
                correctans = question22[5];
                questionoutput.displayedtopic = question22[7];
            }
            if (questionnumber == 23)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question23[0];
                questionoutput.nextanswer1 = question23[1];
                questionoutput.nextanswer2 = question23[2];
                questionoutput.nextanswer3 = question23[3];
                questionoutput.nextanswer4 = question23[4];
                correctans = question23[5];
                questionoutput.displayedtopic = question23[7];
            }
            if (questionnumber == 24)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question24[0];
                questionoutput.nextanswer1 = question24[1];
                questionoutput.nextanswer2 = question24[2];
                questionoutput.nextanswer3 = question24[3];
                questionoutput.nextanswer4 = question24[4];
                correctans = question24[5];
                questionoutput.displayedtopic = question24[7];
            }
            if (questionnumber == 25)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question25[0];
                questionoutput.nextanswer1 = question25[1];
                questionoutput.nextanswer2 = question25[2];
                questionoutput.nextanswer3 = question25[3];
                questionoutput.nextanswer4 = question25[4];
                correctans = question25[5];
                questionoutput.displayedtopic = question25[7];
            }
            if (questionnumber == 26)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question26[0];
                questionoutput.nextanswer1 = question26[3];
                questionoutput.nextanswer2 = question26[4];
                questionoutput.nextanswer3 = question26[1];
                questionoutput.nextanswer4 = question26[2];
                correctans = question26[5];
                questionoutput.displayedtopic = question26[7];
            }
            if (questionnumber == 27)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question27[0];
                questionoutput.nextanswer1 = question27[4];
                questionoutput.nextanswer2 = question27[3];
                questionoutput.nextanswer3 = question27[2];
                questionoutput.nextanswer4 = question27[1];
                correctans = question27[5];
                questionoutput.displayedtopic = question27[7];
            }
            if (questionnumber == 28)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question28[0];
                questionoutput.nextanswer1 = question28[1];
                questionoutput.nextanswer2 = question28[2];
                questionoutput.nextanswer3 = question28[3];
                questionoutput.nextanswer4 = question28[4];
                correctans = question28[5];
                questionoutput.displayedtopic = question28[7];
            }
            if (questionnumber == 29)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question29[0];
                questionoutput.nextanswer1 = question29[2];
                questionoutput.nextanswer2 = question29[3];
                questionoutput.nextanswer3 = question29[1];
                questionoutput.nextanswer4 = question29[4];
                correctans = question29[5];
                questionoutput.displayedtopic = question29[7];
            }
            if (questionnumber == 30)
            {
                //questiondisplayed = true;// there is a question being displayed.
                questionoutput.nextquestion = question30[0];
                questionoutput.nextanswer1 = question30[1];
                questionoutput.nextanswer2 = question30[2];
                questionoutput.nextanswer3 = question30[3];
                questionoutput.nextanswer4 = question30[4];
                correctans = question30[5];
                questionoutput.displayedtopic = question30[7];
            }
            if (questionnumber == 31) 
            {
                //questiondisplayed = true;
                panel.SetActive(true);//makes sure the window is not active
                StartCoroutine(Savedata());//call the coroutine for the end of the quiz
                questionnumber = 1;
                enabled = false;



            }
            

        }
    
    }
    IEnumerator Savedata()
    {
        yield return new WaitForSeconds(0.001f);//wait for two before moving on
        algebraAskedi = int.Parse(mathRetreival.algebraAsked);
        arithmeticAskedi = int.Parse(mathRetreival.arithmeticAsked);
        fdpAskedi = int.Parse(mathRetreival.fdpAsked);
        algebraCorrecti = int.Parse(mathRetreival.algebraCorrect);
        arithmeticCorrecti = int.Parse(mathRetreival.arithmeticCorrect);
        fdpCorrecti = int.Parse(mathRetreival.fdpCorrect);
        biologyAskedi = int.Parse(scienceRetreival.biologyAsked);
        chemistryAskedi = int.Parse(scienceRetreival.chemistryAsked);
        physicsAskedi = int.Parse(scienceRetreival.physicsAsked);
        biologyCorrecti = int.Parse(scienceRetreival.biologyCorrect);
        chemistryCorrecti= int.Parse(scienceRetreival.chemistryCorrect);
        physicsCorrecti = int.Parse(scienceRetreival.physicsCorrect);
        hardwareAskedi = int.Parse(compRetreival.hardwareAsked);
        softwareAskedi = int.Parse(compRetreival.softwareAsked);
        programmingAskedi = int.Parse(compRetreival.programmingAsked);
        hardwareCorrecti = int.Parse(compRetreival.hardwareCorrect);
        softwareCorrecti = int.Parse(compRetreival.softwareCorrect);
        programmingCorrecti = int.Parse(compRetreival.programmingCorrect);


        if (beginQuiz.parsedsubject == "maths")
        {

            //updates students progress in variables
            algebraAskedi += calculatemathsQs.algebraQuestionCount;
            arithmeticAskedi += calculatemathsQs.arithmeticQuestionCount;
            fdpAskedi += calculatemathsQs.fdpQuestionCount;
            algebraCorrecti += answering.topic1correct;
            arithmeticCorrecti += answering.topic2correct;
            fdpCorrecti += answering.topic3correct;
            //calculates %correct and correctly answered
            totalmathsscore = answering.topic1correct + answering.topic2correct + answering.topic3correct;
            percentagescore = Convert.ToInt32(((float)totalmathsscore / 30) * 100);

            //output whats needed to be outputted
            timetakenend.GetComponent<Text>().text = "Time: " + questionoutput.integerTimes.ToString() + " seconds";
            questionscorrect.GetComponent<Text>().text = "total score: " + totalmathsscore.ToString();
            correctpercentage.GetComponent<Text>().text = "percentage: " + percentagescore.ToString() + "%";


        }

        //post quiz screens- is different for every subject- decided based on the parsedsubject value
        if (beginQuiz.parsedsubject == "science")
        {
            //updates students progress in variables for science
            biologyAskedi += calculatescienceQs.biologyQuestionCount;
            chemistryAskedi += calculatescienceQs.chemistryQuestionCount;
            physicsAskedi += calculatescienceQs.physicsQuestionCount;
            biologyCorrecti = biologyCorrecti+answering.topic1correct;
            chemistryCorrecti = chemistryCorrecti+answering.topic2correct;
            
            physicsCorrecti = physicsCorrecti+answering.topic3correct;
            //calculates %correct and correctly answered
            totalsciencescore = answering.topic1correct + answering.topic2correct + answering.topic3correct;
            percentagescore = Convert.ToInt32(((float)totalsciencescore / 30) * 100);

            //output whats needed to be outputted
            timetakenend.GetComponent<Text>().text = "Time: " + questionoutput.integerTimes.ToString() + " seconds";
            questionscorrect.GetComponent<Text>().text = "total score: " + totalsciencescore.ToString();
            correctpercentage.GetComponent<Text>().text = "percentage: " + percentagescore.ToString() + "%";
            Debug.Log("chem correct "+chemistryCorrecti);
            Debug.Log("bio correct " + biologyCorrecti);
            Debug.Log("physics asked " + physicsAskedi);

        }
        if (beginQuiz.parsedsubject == "computing")
        {
            // updates students progress in variables
            hardwareAskedi = hardwareAskedi+calculatecomputingQs.hardwareQuestionCount;
            softwareAskedi += calculatecomputingQs.softwareQuestionCount;
            programmingAskedi += calculatecomputingQs.programmingQuestionCount;
            hardwareCorrecti += answering.topic1correct;
            softwareCorrecti += answering.topic2correct;
            programmingCorrecti += answering.topic3correct;
            //calculates %correct and correctly answered
            totalcomputingscore = answering.topic1correct + answering.topic2correct + answering.topic3correct;
            percentagescore = Convert.ToInt32(((float)totalcomputingscore / 30) * 100);

            //output whats needed to be outputted
            timetakenend.GetComponent<Text>().text = "Time: " + questionoutput.integerTimes.ToString() + " seconds";
            questionscorrect.GetComponent<Text>().text = "total score: " + totalcomputingscore.ToString();
            correctpercentage.GetComponent<Text>().text = "percentage: " + percentagescore.ToString() + "%";


        }
        else
        {

        }

    }

}





