using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ValueCalculator : MonoBehaviour
{
    //create public static ints for the existing values we have because they are strings

    public static int algebraAsked = int.Parse(mathRetreival.algebraAsked);
    public static int algebraCorrect = int.Parse(mathRetreival.algebraCorrect);
    public static int arithmeticAsked = int.Parse(mathRetreival.arithmeticAsked);
    public static int arithmeticCorrect = int.Parse(mathRetreival.arithmeticCorrect);
    public static int fdpAsked = int.Parse(mathRetreival.fdpAsked);
    public static int fdpCorrect = int.Parse(mathRetreival.fdpCorrect);

    public static int biologyAsked = int.Parse(scienceRetreival.biologyAsked);
    public static int biologyCorrect = int.Parse(scienceRetreival.biologyCorrect);
    public static int chemistryAsked = int.Parse(scienceRetreival.chemistryAsked);
    public static int chemistryCorrect = int.Parse(scienceRetreival.chemistryCorrect);
    public static int physicsAsked = int.Parse(scienceRetreival.physicsAsked);
    public static int physicsCorrect = int.Parse(scienceRetreival.physicsCorrect);

    public static int hardwareAsked = int.Parse(compRetreival.hardwareAsked);
    public static int hardwareCorrect = int.Parse(compRetreival.hardwareCorrect);
    public static int softwareAsked = int.Parse(compRetreival.softwareAsked);
    public static int softwareCorrect = int.Parse(compRetreival.softwareCorrect);
    public static int programmingAsked = int.Parse(compRetreival.programmingAsked);
    public static int programmingCorrect = int.Parse(compRetreival.programmingCorrect);



    public static int totalmathsasked;
    public static int totalmathscorrect;
    public static int totalscienceasked;
    public static int totalsciencecorrect;
    public static int totalcomputingasked;
    public static int totalcomputingcorrect;

    //percentages for each topic
    public static int algebrapercentage;
    public static int arithmeticpercentage;
    public static int fdppercentage;
    public static int biologypercentage;
    public static int chemistrypercentage;
    public static int physicspercentage;
    public static int hardwarepercentage;
    public static int softwarepercentage;
    public static int programmingpercentage;


    // Start is called before the first frame update
    void Start()
    {
        //genearal totals of questions asked and questions correct
        totalmathsasked = algebraAsked + arithmeticAsked + fdpAsked;
        totalscienceasked = biologyAsked + chemistryAsked + physicsAsked;
        totalcomputingasked = hardwareAsked + softwareAsked + programmingAsked;
        totalmathscorrect = algebraCorrect + arithmeticCorrect + fdpCorrect;
        totalsciencecorrect = biologyCorrect + chemistryCorrect + physicsCorrect;
        totalcomputingcorrect = softwareCorrect + programmingCorrect + hardwareCorrect;

        //percentages for each topic making it into integers
        algebrapercentage = 0;
        if (algebraAsked != 0)
        {
            algebrapercentage = Convert.ToInt32((float)(((float)algebraCorrect / algebraAsked) * 100f));
        }
        arithmeticpercentage = 0;
        if (arithmeticAsked != 0)
        {
            arithmeticpercentage = Convert.ToInt32((float)(((float)arithmeticCorrect / arithmeticAsked) * 100f));
        }
        fdppercentage = 0;
        if (fdpAsked != 0)
        {
            fdppercentage = Convert.ToInt32((float)(((float)fdpCorrect / fdpAsked) * 100f));
        }

        //computing
        hardwarepercentage = 0;
        if (hardwareAsked != 0)
        {
            hardwarepercentage = Convert.ToInt32((float)(((float)hardwareCorrect / hardwareAsked) * 100f));
        }

        softwarepercentage = 0;
        if (softwareAsked != 0)
        {
            softwarepercentage = Convert.ToInt32((float)(((float)softwareCorrect / softwareAsked) * 100f));
        }

        programmingpercentage = 0;
        if (programmingAsked != 0)
        {
            programmingpercentage = Convert.ToInt32((float)(((float)programmingCorrect / programmingAsked) * 100f));
        }

        //science
        biologypercentage = 0;
        if (biologyAsked != 0)
        {
            biologypercentage = Convert.ToInt32((float)(((float)biologyCorrect / biologyAsked) * 100f));
        }

        chemistrypercentage = 0;
        if (chemistryAsked != 0)
        {
            chemistrypercentage = Convert.ToInt32((float)(((float)chemistryCorrect / chemistryAsked) * 100f));
        }

        physicspercentage = 0;
        if (physicsAsked != 0)
        {
            physicspercentage = Convert.ToInt32((float)(((float)physicsCorrect / physicsAsked) * 100f));
        }




    }

}

