using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculatescienceQs : MonoBehaviour
{
    // Define private variables to store the retrieved values as floats
    private float fscienceOverall;
    private float foverallAverage;
    private float fbiologyAsked;
    private float fbiologyCorrect;
    private float fchemistryAsked;
    private float fchemistryCorrect;
    private float fphysicsAsked;
    private float fphysicsCorrect;
    public static int biologyQuestionCount;
    public static int chemistryQuestionCount;
    public static int physicsQuestionCount;
    void Start()
    {
        Debug.Log(scienceRetreival.scienceOverall);
        // Retrieve the values from the scienceRetreival script
        //Debug.Log(float.TryParse(scienceRetreival.scienceOverall));

        fscienceOverall = float.Parse((scienceRetreival.scienceOverall));
        foverallAverage = float.Parse(scienceRetreival.overallAverage);
        fbiologyAsked = float.Parse(scienceRetreival.biologyAsked);
        fbiologyCorrect = float.Parse(scienceRetreival.biologyCorrect);
        fchemistryAsked = float.Parse(scienceRetreival.chemistryAsked);
        fchemistryCorrect = float.Parse(scienceRetreival.chemistryCorrect);
        fphysicsAsked = float.Parse(scienceRetreival.physicsAsked);
        fphysicsCorrect = float.Parse(scienceRetreival.physicsCorrect);

        Debug.Log("science Overall (Float): " + fscienceOverall);
        if (fphysicsAsked >= 10 || fchemistryAsked >= 10 || fbiologyAsked >= 10)
        {
            // work out percentage correct for each category
            float biologypercentage = fbiologyCorrect / fbiologyAsked;
            float chemistrypercentage = fchemistryCorrect / fchemistryAsked;
            float physicspercentage = fphysicsCorrect / fphysicsAsked;

            //total of percentages.
            float totalPercentage = biologypercentage + chemistrypercentage + physicspercentage;

            // Calculate proportion variables
            float biologyProportion = 1 - (biologypercentage / totalPercentage);
            float chemistryProportion = 1 - (chemistrypercentage / totalPercentage);
            float physicsProportion = 1 - (physicspercentage / totalPercentage);
            //Here, 1f is used instead of 1 to indicate that the value is a float.

            // Calculate the number of questions for each topic, and rounds them to the nearest int

            biologyQuestionCount = Mathf.RoundToInt((30 * biologyProportion) / 2);
            chemistryQuestionCount = Mathf.RoundToInt((30 * chemistryProportion) / 2);
            physicsQuestionCount = Mathf.RoundToInt((30 * physicsProportion) / 2);
            int totalquestions = biologyQuestionCount + chemistryQuestionCount + physicsQuestionCount;
            if (totalquestions < 30)
            {
                physicsQuestionCount++;
                totalquestions = biologyQuestionCount + chemistryQuestionCount + physicsQuestionCount;

            }
            if (totalquestions > 30)
            {
                chemistryQuestionCount = chemistryQuestionCount - 1;
                totalquestions = biologyQuestionCount + chemistryQuestionCount + physicsQuestionCount;
            }

            Debug.Log("biologynumber qs: " + biologyQuestionCount);
            Debug.Log("chemistrynumber qs: " + chemistryQuestionCount);
            Debug.Log("physics qs: " + physicsQuestionCount);
            Debug.Log("sum of quesions: " + totalquestions);
        }
        else
        {
            biologyQuestionCount = 10;
            chemistryQuestionCount = 10;
            physicsQuestionCount = 10;
            int totalquestions = biologyQuestionCount + chemistryQuestionCount + physicsQuestionCount;
            Debug.Log("biologynumber qs: " + biologyQuestionCount);
            Debug.Log("chemistrynumber qs: " + chemistryQuestionCount);
            Debug.Log("physics qs: " + physicsQuestionCount);
            Debug.Log("sum of quesions: " + totalquestions);
        }


    }
}
