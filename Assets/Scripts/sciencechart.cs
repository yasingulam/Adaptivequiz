using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AwesomeCharts;

public class sciencechart : MonoBehaviour
{
    public BarChart chartscience; // reference to the AwesomeChart object in the scene


    // Start is called before the first frame update
    void Start()
    {
        BarDataSet set = new BarDataSet();
        // Add entries to data set
        set.AddEntry(new BarEntry(0, ValueCalculator.biologypercentage));
        set.AddEntry(new BarEntry(1, ValueCalculator.chemistrypercentage));
        set.AddEntry(new BarEntry(2, ValueCalculator.physicspercentage));

    
        set.BarColors.Add(Color.red);
        set.BarColors.Add(Color.yellow);
        set.BarColors.Add(Color.green);

        // Add data set to chart data
        chartscience.GetChartData().DataSets.Add(set);
    }
}
