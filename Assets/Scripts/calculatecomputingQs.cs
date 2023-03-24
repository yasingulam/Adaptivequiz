using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculatecomputingQs : MonoBehaviour
{
    // Define private variables to store the retrieved values as floats
    private float fcomputingOverall;
    private float foverallAverage;
    private float fhardwareAsked;
    private float fhardwareCorrect;
    private float fsoftwareAsked;
    private float fsoftwareCorrect;
    private float fprogrammingAsked;
    private float fprogrammingCorrect;
    public static int hardwareQuestionCount;
    public static int softwareQuestionCount;
    public static int programmingQuestionCount;
    void Start()
    {
        Debug.Log(compRetreival.computingOverall);
        // Retrieve the values from the compRetreival script
        //Debug.Log(float.TryParse(compRetreival.computingOverall));

        fcomputingOverall = float.Parse((compRetreival.computingOverall));
        foverallAverage = float.Parse(compRetreival.overallAverage);
        fhardwareAsked = float.Parse(compRetreival.hardwareAsked);
        fhardwareCorrect = float.Parse(compRetreival.hardwareCorrect);
        fsoftwareAsked = float.Parse(compRetreival.softwareAsked);
        fsoftwareCorrect = float.Parse(compRetreival.softwareCorrect);
        fprogrammingAsked = float.Parse(compRetreival.programmingAsked);
        fprogrammingCorrect = float.Parse(compRetreival.programmingCorrect);

        Debug.Log("computing Overall (Float): " + fcomputingOverall);
        if (fprogrammingAsked >= 10 || fsoftwareAsked >= 10 || fhardwareAsked >= 10)
        {
            // work out percentage correct for each category
            float hardwarepercentage = fhardwareCorrect / fhardwareAsked;
            float softwarepercentage = fsoftwareCorrect / fsoftwareAsked;
            float programmingpercentage = fprogrammingCorrect / fprogrammingAsked;

            //total of percentages.
            float totalPercentage = hardwarepercentage + softwarepercentage + programmingpercentage;

            // Calculate proportion variables
            float hardwareProportion = 1 - (hardwarepercentage / totalPercentage);
            float softwareProportion = 1 - (softwarepercentage / totalPercentage);
            float programmingProportion = 1 - (programmingpercentage / totalPercentage);
            //Here, 1f is used instead of 1 to indicate that the value is a float.

            // Calculate the number of questions for each topic, and rounds them to the nearest int

            hardwareQuestionCount = Mathf.RoundToInt((30 * hardwareProportion) / 2);
            softwareQuestionCount = Mathf.RoundToInt((30 * softwareProportion) / 2);
            programmingQuestionCount = Mathf.RoundToInt((30 * programmingProportion) / 2);
            int totalquestions = hardwareQuestionCount + softwareQuestionCount + programmingQuestionCount;
            if (totalquestions < 30)
            {
                programmingQuestionCount++;
                totalquestions = hardwareQuestionCount + softwareQuestionCount + programmingQuestionCount;

            }
            if (totalquestions > 30)
            {
                softwareQuestionCount = softwareQuestionCount - 1;
                totalquestions = hardwareQuestionCount + softwareQuestionCount + programmingQuestionCount;
            }

            Debug.Log("hardwarenumber qs: " + hardwareQuestionCount);
            Debug.Log("softwarenumber qs: " + softwareQuestionCount);
            Debug.Log("programming qs: " + programmingQuestionCount);
            Debug.Log("sum of quesions: " + totalquestions);
        }
        else
        {
            hardwareQuestionCount = 10;
            softwareQuestionCount = 10;
            programmingQuestionCount = 10;
            int totalquestions = hardwareQuestionCount + softwareQuestionCount + programmingQuestionCount;
            Debug.Log("hardwarenumber qs: " + hardwareQuestionCount);
            Debug.Log("softwarenumber qs: " + softwareQuestionCount);
            Debug.Log("programming qs: " + programmingQuestionCount);
            Debug.Log("sum of quesions: " + totalquestions);
        }


    }
}
