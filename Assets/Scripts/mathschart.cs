using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AwesomeCharts;

public class mathschart : MonoBehaviour
{
    public BarChart chart; // reference to the AwesomeChart object in the scene


    // Start is called before the first frame update
    void Start()
    {
        BarDataSet set = new BarDataSet();
        // Add entries to data set
        set.AddEntry(new BarEntry(0, ValueCalculator.algebrapercentage));
        set.AddEntry(new BarEntry(1, ValueCalculator.arithmeticpercentage));
        set.AddEntry(new BarEntry(2, ValueCalculator.fdppercentage));

    
        set.BarColors.Add(Color.red);
        set.BarColors.Add(Color.yellow);
        set.BarColors.Add(Color.green);

        // Add data set to chart data
        chart.GetChartData().DataSets.Add(set);
    }
}
