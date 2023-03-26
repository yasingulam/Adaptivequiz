using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ValueCalculator : MonoBehaviour
{
    public static int algebraAsked;
    public static int algebraCorrect;
    public static int arithmeticAsked;
    public static int arithmeticCorrect;
    public static int fdpAsked;
    public static int fdpCorrect;

    public static int biologyAsked;
    public static int biologyCorrect;
    public static int chemistryAsked;
    public static int chemistryCorrect;
    public static int physicsAsked;
    public static int physicsCorrect;

    public static int hardwareAsked;
    public static int hardwareCorrect;
    public static int softwareAsked;
    public static int softwareCorrect;
    public static int programmingAsked;
    public static int programmingCorrect;

    public static int totalmathsasked;
    public static int totalmathscorrect;
    public static int totalscienceasked;
    public static int totalsciencecorrect;
    public static int totalcomputingasked;
    public static int totalcomputingcorrect;

    public static int algebrapercentage;
    public static int arithmeticpercentage;
    public static int fdppercentage;
    public static int biologypercentage;
    public static int chemistrypercentage;
    public static int physicspercentage;
    public static int hardwarepercentage;
    public static int softwarepercentage;
    public static int programmingpercentage;

    void Start()
    {
        UpdateValues();
    }

    public static void UpdateValues()
    {
        algebraAsked = int.Parse(mathRetreival.algebraAsked);
        algebraCorrect = int.Parse(mathRetreival.algebraCorrect);
        arithmeticAsked = int.Parse(mathRetreival.arithmeticAsked);
        arithmeticCorrect = int.Parse(mathRetreival.arithmeticCorrect);
        fdpAsked = int.Parse(mathRetreival.fdpAsked);
        fdpCorrect = int.Parse(mathRetreival.fdpCorrect);

        biologyAsked = int.Parse(scienceRetreival.biologyAsked);
        biologyCorrect = int.Parse(scienceRetreival.biologyCorrect);
        chemistryAsked = int.Parse(scienceRetreival.chemistryAsked);
        chemistryCorrect = int.Parse(scienceRetreival.chemistryCorrect);
        physicsAsked = int.Parse(scienceRetreival.physicsAsked);
        physicsCorrect = int.Parse(scienceRetreival.physicsCorrect);

        hardwareAsked = int.Parse(compRetreival.hardwareAsked);
        hardwareCorrect = int.Parse(compRetreival.hardwareCorrect);
        softwareAsked = int.Parse(compRetreival.softwareAsked);
        softwareCorrect = int.Parse(compRetreival.softwareCorrect);
        programmingAsked = int.Parse(compRetreival.programmingAsked);
        programmingCorrect = int.Parse(compRetreival.programmingCorrect);

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
