using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class calculatemathsQs : MonoBehaviour
{
    // Define private variables to store the retrieved values as floats
    private float fmathOverall;
    private float foverallAverage;
    private float falgebraAsked;
    private float falgebraCorrect;
    private float farithmeticAsked;
    private float farithmeticCorrect;
    private float ffdpAsked;
    private float ffdpCorrect;
    public static int algebraQuestionCount;
    public static int arithmeticQuestionCount;
    public static int fdpQuestionCount;

    void Start()
    {
        Debug.Log(mathRetreival.mathOverall);
        // Retrieve the values from the mathRetreival script
        //Debug.Log(float.TryParse(mathRetreival.mathOverall));

        fmathOverall = float.Parse((mathRetreival.mathOverall));
        foverallAverage = float.Parse(mathRetreival.overallAverage);
        falgebraAsked = float.Parse(mathRetreival.algebraAsked);
        falgebraCorrect = float.Parse(mathRetreival.algebraCorrect);
        farithmeticAsked = float.Parse(mathRetreival.arithmeticAsked);
        farithmeticCorrect = float.Parse(mathRetreival.arithmeticCorrect);
        ffdpAsked = float.Parse(mathRetreival.fdpAsked);
        ffdpCorrect = float.Parse(mathRetreival.fdpCorrect);

        Debug.Log("Math Overall (Float): " + fmathOverall);

        //checks if the asked questions is at least 10 for topic || means OR
        if (ffdpAsked >= 10 || farithmeticAsked >= 10 || falgebraAsked >= 10)
        {
            // work out percentage correct for each category
            float algebrapercentage = falgebraCorrect / falgebraAsked;
            float arithmeticpercentage = farithmeticCorrect / farithmeticAsked;
            float fdppercentage = ffdpCorrect / ffdpAsked;

            //total of percentages.
            float totalPercentage = algebrapercentage + arithmeticpercentage + fdppercentage;

            // Calculate proportion variables
            float algebraProportion = 1 - (algebrapercentage / totalPercentage);
            float arithmeticProportion = 1 - (arithmeticpercentage / totalPercentage);
            float fdpProportion = 1 - (fdppercentage / totalPercentage);
            //Here, 1f is used instead of 1 to indicate that the value is a float.

            // Calculate the number of questions for each topic, and rounds them to the nearest int

            algebraQuestionCount = Mathf.RoundToInt((30 * algebraProportion) / 2);
            arithmeticQuestionCount = Mathf.RoundToInt((30 * arithmeticProportion) / 2);
            fdpQuestionCount = Mathf.RoundToInt((30 * fdpProportion) / 2);
            int totalquestions = algebraQuestionCount + arithmeticQuestionCount + fdpQuestionCount;


            Debug.Log("algebranumber qs: " + algebraQuestionCount);
            Debug.Log("arithmeticnumber qs: " + arithmeticQuestionCount);
            Debug.Log("fdp qs: " + fdpQuestionCount);
            Debug.Log("sum of quesions: " + totalquestions);
        }
        else
        {
            algebraQuestionCount = 10;
            arithmeticQuestionCount = 10;
            fdpQuestionCount = 10;
            int totalquestions = algebraQuestionCount + arithmeticQuestionCount + fdpQuestionCount;
            Debug.Log("algebranumber qs: " + algebraQuestionCount);
            Debug.Log("arithmeticnumber qs: " + arithmeticQuestionCount);
            Debug.Log("fdp qs: " + fdpQuestionCount);
            Debug.Log("sum of quesions: " + totalquestions);
        }
    }
}
