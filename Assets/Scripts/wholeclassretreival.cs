using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using AwesomeCharts;
public class wholeclassretreival : MonoBehaviour
{
    //Create the UI placeholders, which will later be set to their corresoponding variables


    public Text mathsaveragetext;
    public Text scienceaveragetext;
    public Text computingaveragetext;
    public Text numberofstudentstext;
    public Text bestsubjecttext;
    public Text worstsubjecttext;
    public Text totalmathstext;
    public Text algebraaveragetext;
    public Text arithmeticaveragetext;
    public Text fdpaveragetext;
    public Text bestmathstopictext;
    public Text worstmathstopictext;
    public Text totalsciencetext;
    public Text biologyaveragetext;
    public Text chemistryaveragetext;
    public Text physicsaveragetext;
    public Text bestsciencetopictext;
    public Text worstsciencetopictext;
    public Text totalcomputingtext;
    public Text hardwareaveragetext;
    public Text softwareaveragetext;
    public Text programmingaveragetext;
    public Text bestcomputingtopictext;
    public Text worstcomputingtopictext;


    public string bestsubject;
    public string worstsubject;
    public string bestmathtopic;
    public string worstmathtopic;
    public string bestsciencetopic;
    public string worstsciencetopic;
    public string bestcomputingtopic;
    public string worstcomputingtopic;
    public int studentcount;

    public int averagemathsscore;
    public int averagesciencescore;
    public int averagecomputingscore;

    public BarChart chartmaths;
    public BarChart chartscience;
    public BarChart chartcomputing;

    // Coroutine to retrieve data from a PHP script
    IEnumerator Start()
    {
        // Replace the URL with the location of your PHP script
        string url = "http://localhost/unity/Register/wholeclass.php";

        // Send a GET request to the PHP script and wait for a response
        WWW www = new WWW(url);
        yield return www;

        // If there was an error, log the error message and exit the coroutine
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }



        // Parse the comma-separated values returned by the PHP script
        //the php will make one big list out of the items, seperated by commas
        string[] values = www.text.Split(',');
        Debug.Log("hardware asked: " + values[0]);
        int hardware_asked = int.Parse(values[0]);
        int hardware_correct = int.Parse(values[1]);
        int software_asked = int.Parse(values[2]);
        int software_correct = int.Parse(values[3]);
        int programming_asked = int.Parse(values[4]);
        int programming_correct = int.Parse(values[5]);
        int algebra_asked = int.Parse(values[6]);
        int algebra_correct = int.Parse(values[7]);
        int arithmetic_asked = int.Parse(values[8]);
        int arithmetic_correct = int.Parse(values[9]);
        int fdp_asked = int.Parse(values[10]);
        int fdp_correct = int.Parse(values[11]);
        int biology_asked = int.Parse(values[12]);
        int biology_correct = int.Parse(values[13]);
        int chemistry_asked = int.Parse(values[14]);
        int chemistry_correct = int.Parse(values[15]);
        int physics_asked = int.Parse(values[16]);
        int physics_correct = int.Parse(values[17]);
        int studentcount = int.Parse(values[18]);


        Debug.Log("hardware correct:  " + hardware_correct);
        Debug.Log("programming correct:  " + programming_correct);

        //calculate the percentages per subject and round to integer
        averagemathsscore = Convert.ToInt32((float)(((float)algebra_correct + arithmetic_correct + fdp_correct) / (arithmetic_asked + algebra_asked + fdp_asked)) * 100f);
        averagesciencescore = Convert.ToInt32((float)(((float)biology_correct + chemistry_correct + physics_correct) / (chemistry_asked + biology_asked + physics_asked)) * 100f);
        averagecomputingscore = Convert.ToInt32((float)(((float)hardware_correct + software_correct + programming_correct) / (software_asked + hardware_asked + programming_asked)) * 100f);
        Debug.Log("average computing:  " + averagecomputingscore);


        //determine best and worst subjects, by comparing average scores
        if ((averagemathsscore > averagesciencescore) && (averagemathsscore > averagecomputingscore))
        {
            bestsubject = "maths";

        }
        else if (averagecomputingscore > averagesciencescore && averagecomputingscore > averagemathsscore)
        {
            bestsubject = "computing";

        }
        else if (averagesciencescore > averagemathsscore && averagesciencescore > averagecomputingscore)
        {
            bestsubject = "science";
        }
        else// if the values are equal, meaning no subject is better or woese
        {
            worstsubject = "none";
        }

            //worst subjects, by comparing average scores

        if (averagemathsscore < averagesciencescore && averagemathsscore < averagecomputingscore)
        {
            worstsubject = "maths";

        }
        else if (averagecomputingscore < averagesciencescore && averagecomputingscore < averagemathsscore)
        {
            worstsubject = "computing";

        }
        else if (averagesciencescore < averagemathsscore && averagesciencescore < averagecomputingscore)
        {
            worstsubject = "science";
        }
        else// if the values are equal, meaning no subject is better or woese
        {
            bestsubject= "none";
        }





        //////////////////////MATHS///////////////////////////////
        ///

        int totalmathsasked = algebra_asked + arithmetic_asked + fdp_asked;

        int algebraaverage = Convert.ToInt32((float)(((float)algebra_correct / algebra_asked) * 100f));
        int arithmeticaverage = Convert.ToInt32((float)(((float)arithmetic_correct / arithmetic_asked) * 100f));
        int fdpaverage = Convert.ToInt32((float)(((float)fdp_correct / fdp_asked) * 100f));

        //determine best and worst subjects, by comparing average scores
        if (algebraaverage > arithmeticaverage && algebraaverage > fdpaverage)
        {
            bestmathtopic = "algebra";

        }
        else if (fdpaverage > arithmeticaverage && fdpaverage > algebraaverage)
        {
            bestmathtopic = "fdp";

        }
        else if (arithmeticaverage > algebraaverage && arithmeticaverage > fdpaverage)
        {
            bestmathtopic = "arithmetic";
        }
        else
        {
            bestmathtopic = "none";
        }
            //worst mathtopics, by comparing average scores

        if (algebraaverage < arithmeticaverage && algebraaverage < fdpaverage)
        {
            worstmathtopic = "algebra";

        }
        else if (fdpaverage < arithmeticaverage && fdpaverage < algebraaverage)
        {
            worstmathtopic = "fdp";

        }
        else if (arithmeticaverage < algebraaverage && arithmeticaverage < fdpaverage)
        {
            worstmathtopic = "arithmetic";
        }
        else 
        {

            worstmathtopic = "none";

        }





        //////////////////////science///////////////////////////////
        ///

        int totalscienceasked = biology_asked + chemistry_asked + physics_asked;

        int biologyaverage = Convert.ToInt32(((float)biology_correct / biology_asked) * 100f);
        int chemistryaverage = Convert.ToInt32(((float)chemistry_correct / chemistry_asked) * 100f);
        int physicsaverage = Convert.ToInt32(((float)physics_correct / physics_asked) * 100f);

        //determine best and worst topics, by comparing average scores
        if (biologyaverage > chemistryaverage && biologyaverage > physicsaverage)
        {
            bestsciencetopic = "biology";

        }
        else if (physicsaverage > chemistryaverage && physicsaverage > biologyaverage)
        {
            bestsciencetopic = "physics";

        }
        else if (chemistryaverage > biologyaverage && chemistryaverage > physicsaverage)
        {
            bestsciencetopic = "chemistry";
        }
        else
        {
            bestsciencetopic = "none";
        }

        //worst sciencetopics, by comparing average scores

        if (biologyaverage < chemistryaverage && biologyaverage < physicsaverage)
        {
            worstsciencetopic = "biology";

        }
        else if (physicsaverage < chemistryaverage && physicsaverage < biologyaverage)
        {
            worstsciencetopic = "physics";

        }
        else if (chemistryaverage < biologyaverage && chemistryaverage < physicsaverage)
        {
            worstsciencetopic = "chemistry";
        }
        else //if values are equal or zero
        {

            worstsciencetopic = "none";
        }





        //////////////////////computing///////////////////////////////
        ///

        int totalcomputingasked = hardware_asked + software_asked + programming_asked;

        int hardwareaverage = Convert.ToInt32((float)(((float)hardware_correct / hardware_asked) * 100f));
        int softwareaverage = Convert.ToInt32((float)(((float)software_correct / software_asked) * 100f));
        int programmingaverage = Convert.ToInt32((float)(((float)programming_correct / programming_asked) * 100f));

        //determine best and worst topics, by comparing average scores
        if (hardwareaverage > softwareaverage && hardwareaverage > programmingaverage)
        {
            bestcomputingtopic = "hardware";

        }
        else if (programmingaverage > softwareaverage && programmingaverage > hardwareaverage)
        {
            bestcomputingtopic = "programming";

        }
        else if (softwareaverage > hardwareaverage && softwareaverage > programmingaverage)
        {
            bestcomputingtopic = "software";
        }
        else
        {
            bestcomputingtopic = "none";
        }
        //worst computingtopics, by comparing average scores

        if (hardwareaverage < softwareaverage && hardwareaverage < programmingaverage)
        {
            worstcomputingtopic = "hardware";

        }
        else if (programmingaverage < softwareaverage && programmingaverage < hardwareaverage)
        {
            worstcomputingtopic = "programming";

        }
        else if (softwareaverage < hardwareaverage && softwareaverage < programmingaverage)
        {
            worstcomputingtopic = "software";
        }
        else
        {

            worstcomputingtopic = "none";

        }
        //coniguring gameobjects to their vaiable
        mathsaveragetext.text = "Average score: "+averagemathsscore.ToString()+"%";
        scienceaveragetext.text = "Average score: " + averagesciencescore.ToString() + "%";
        computingaveragetext.text = "Average score: " + averagecomputingscore.ToString() + "%";
        numberofstudentstext.text = "Number of students: " + studentcount.ToString();
        bestsubjecttext.text = "Best Subject: " + bestsubject;
        worstsubjecttext.text = "Worst Subject: " + worstsubject;
        
        
        totalmathstext.text = "Questions asked: " + totalmathsasked.ToString();
        algebraaveragetext.text = "Algebra Average: " + algebraaverage.ToString() + "%";
        arithmeticaveragetext.text= "Arithmetic Average: " + arithmeticaverage.ToString() + "%";
        fdpaveragetext.text= "FDP Average: " + fdpaverage.ToString() + "%";
        bestmathstopictext.text = "Best Topic: " + bestmathtopic;
        worstmathstopictext.text = "Worst Topic: " + worstmathtopic;
        
        totalsciencetext.text = "Questions asked: " + totalscienceasked.ToString();
        biologyaveragetext.text= "Biology Average: " + biologyaverage.ToString() + "%";
        chemistryaveragetext.text= "Chemistry Average: " + chemistryaverage.ToString() + "%";
        physicsaveragetext.text= "Physics Average: " + physicsaverage.ToString() + "%";
        bestsciencetopictext.text = "Best Topic: " + bestsciencetopic;
        worstsciencetopictext.text = "Worst Topic: " + worstsciencetopic;
        
        totalcomputingtext.text = "Questions asked: " + totalcomputingasked.ToString();
        hardwareaveragetext.text= "Hardware Average: " + hardwareaverage.ToString() + "%";
        softwareaveragetext.text= "Software Average: " + softwareaverage.ToString() + "%";
        programmingaveragetext.text= "Programming Average: " + programmingaverage.ToString() + "%";
        bestcomputingtopictext.text = "Best Topic: " + bestcomputingtopic;
        worstcomputingtopictext.text = "Worst Topic: " + worstcomputingtopic;

        // Maths chart
        BarDataSet mathSet = new BarDataSet();
        // Add entries to data set
        mathSet.AddEntry(new BarEntry(0, algebraaverage));
        mathSet.AddEntry(new BarEntry(1, arithmeticaverage));
        mathSet.AddEntry(new BarEntry(2, fdpaverage));

        mathSet.BarColors.Add(Color.red);
        mathSet.BarColors.Add(Color.yellow);
        mathSet.BarColors.Add(Color.green);

        // Add data set to chart data
        chartmaths.GetChartData().DataSets.Add(mathSet);

        // Science chart
        BarDataSet scienceSet = new BarDataSet();
        // Add entries to data set
        scienceSet.AddEntry(new BarEntry(0, biologyaverage));
        scienceSet.AddEntry(new BarEntry(1, chemistryaverage));
        scienceSet.AddEntry(new BarEntry(2, physicsaverage));

        scienceSet.BarColors.Add(Color.red);
        scienceSet.BarColors.Add(Color.yellow);
        scienceSet.BarColors.Add(Color.green);

        // Add data set to chart data
        chartscience.GetChartData().DataSets.Add(scienceSet);

        // Computing chart
        BarDataSet computingSet = new BarDataSet();
        // Add entries to data set
        computingSet.AddEntry(new BarEntry(0, hardwareaverage));
        computingSet.AddEntry(new BarEntry(1, softwareaverage));
        computingSet.AddEntry(new BarEntry(2, programmingaverage));

        computingSet.BarColors.Add(Color.red);
        computingSet.BarColors.Add(Color.yellow);
        computingSet.BarColors.Add(Color.green);

        // Add data set to chart data
        chartcomputing.GetChartData().DataSets.Add(computingSet);





    }
}