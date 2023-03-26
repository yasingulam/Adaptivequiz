using UnityEngine;
using UnityEngine.UI;

public class Displayanalytics : MonoBehaviour
{

    //define the gameobjects as variables.
    public Text totalMathsAskedText;
    public Text totalScienceAskedText;
    public Text totalComputingAskedText;
    public Text totalMathsCorrectText;
    public Text totalScienceCorrectText;
    public Text totalComputingCorrectText;
    public Text algebraPercentageText;
    public Text arithmeticPercentageText;
    public Text fdpPercentageText;
    public Text biologyPercentageText;
    public Text chemistryPercentageText;
    public Text physicsPercentageText;
    public Text hardwarePercentageText;
    public Text softwarePercentageText;
    public Text programmingPercentageText;
    public Text algebraAskedText;
    public Text algebraCorrectText;
    public Text arithmeticAskedText;
    public Text arithmeticCorrectText;
    public Text fdpAskedText;
    public Text fdpCorrectText;
    public Text biologyAskedText;
    public Text biologyCorrectText;
    public Text chemistryAskedText;
    public Text chemistryCorrectText;
    public Text physicsAskedText;
    public Text physicsCorrectText;
    public Text hardwareAskedText;
    public Text hardwareCorrectText;
    public Text softwareAskedText;
    public Text softwareCorrectText;
    public Text programmingAskedText;
    public Text programmingCorrectText;

    void Start()
    {
        // Get the values from the ValueCalculator class
        int totalMathsAsked = ValueCalculator.totalmathsasked;
        int totalScienceAsked = ValueCalculator.totalscienceasked;
        int totalComputingAsked = ValueCalculator.totalcomputingasked;
        int totalMathsCorrect = ValueCalculator.totalmathscorrect;
        int totalScienceCorrect = ValueCalculator.totalsciencecorrect;
        int totalComputingCorrect = ValueCalculator.totalcomputingcorrect;
        int algebraPercentage = ValueCalculator.algebrapercentage;
        int arithmeticPercentage = ValueCalculator.arithmeticpercentage;
        int fdpPercentage = ValueCalculator.fdppercentage;
        int biologyPercentage = ValueCalculator.biologypercentage;
        int chemistryPercentage = ValueCalculator.chemistrypercentage;
        int physicsPercentage = ValueCalculator.physicspercentage;
        int hardwarePercentage = ValueCalculator.hardwarepercentage;
        int softwarePercentage = ValueCalculator.softwarepercentage;
        int programmingPercentage = ValueCalculator.programmingpercentage;

        // Update the text objects with the values
        totalMathsAskedText.text = "Total Maths Asked: " + totalMathsAsked.ToString();
        totalScienceAskedText.text = "Total Science Asked: " + totalScienceAsked.ToString();
        totalComputingAskedText.text = "Total Computing Asked: " + totalComputingAsked.ToString();
        totalMathsCorrectText.text = "Total Maths Correct: " + totalMathsCorrect.ToString();
        totalScienceCorrectText.text = "Total Science Correct: " + totalScienceCorrect.ToString();
        totalComputingCorrectText.text = "Total Computing Correct: " + totalComputingCorrect.ToString();
        algebraPercentageText.text = "Algebra Percentage: " + algebraPercentage.ToString() + "%";
        arithmeticPercentageText.text = "Arithmetic Percentage: " + arithmeticPercentage.ToString() + "%";
        fdpPercentageText.text = "FDP Percentage: " + fdpPercentage.ToString() + "%";
        biologyPercentageText.text = "Biology Percentage: " + biologyPercentage.ToString() + "%";
        chemistryPercentageText.text = "Chemistry Percentage: " + chemistryPercentage.ToString() + "%";
        physicsPercentageText.text = "Physics Percentage: " + physicsPercentage.ToString() + "%";
        hardwarePercentageText.text = "Hardware Percentage: " + hardwarePercentage.ToString() + "%";
        softwarePercentageText.text = "Software Percentage: " + softwarePercentage.ToString() + "%";
        programmingPercentageText.text = "Programming Percentage: " + programmingPercentage.ToString() + "%";
        algebraAskedText.text = "Algebra Asked: " + ValueCalculator.algebraAsked.ToString();
        algebraCorrectText.text = "Algebra Correct: " + ValueCalculator.algebraCorrect.ToString();
        arithmeticAskedText.text = "Arithmetic Asked: " + ValueCalculator.arithmeticAsked.ToString();
        arithmeticCorrectText.text = "Arithmetic Correct: " + ValueCalculator.arithmeticCorrect.ToString();
        fdpAskedText.text = "FDP Asked: " + ValueCalculator.fdpAsked.ToString();
        fdpCorrectText.text = "FDP Correct: " + ValueCalculator.fdpCorrect.ToString();
        biologyAskedText.text = "Biology Asked: " + ValueCalculator.biologyAsked.ToString();
        biologyCorrectText.text = "Biology Correct: " + ValueCalculator.biologyCorrect.ToString();
        chemistryAskedText.text = "Chemistry Asked: " + ValueCalculator.chemistryAsked.ToString();
        chemistryCorrectText.text = "Chemistry Correct: " + ValueCalculator.chemistryCorrect.ToString();
        physicsAskedText.text = "Physics Asked: " + ValueCalculator.physicsAsked.ToString();
        physicsCorrectText.text = "Physics Correct: " + ValueCalculator.physicsCorrect.ToString();
        hardwareAskedText.text = "Hardware Asked: " + ValueCalculator.hardwareAsked.ToString();
        hardwareCorrectText.text = "Hardware Correct: " + ValueCalculator.hardwareCorrect.ToString();
        softwareAskedText.text = "Software Asked: " + ValueCalculator.softwareAsked.ToString();
        softwareCorrectText.text = "Software Correct: " + ValueCalculator.softwareCorrect.ToString();
        programmingAskedText.text = "Programming Asked: " + ValueCalculator.programmingAsked.ToString();
        programmingCorrectText.text = "Programming Correct: " + ValueCalculator.programmingCorrect.ToString();
    }

}
