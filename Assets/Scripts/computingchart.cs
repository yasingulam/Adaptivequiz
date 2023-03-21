using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AwesomeCharts;

public class computingchart : MonoBehaviour
{
    public BarChart chartcomputing; // reference to the AwesomeChart object in the scene


    // Start is called before the first frame update
    void Start()
    {
        BarDataSet set = new BarDataSet();
        // Add entries to data set
        set.AddEntry(new BarEntry(0, ValueCalculator.hardwarepercentage));
        set.AddEntry(new BarEntry(1, ValueCalculator.softwarepercentage));
        set.AddEntry(new BarEntry(2, ValueCalculator.programmingpercentage));

    
        set.BarColors.Add(Color.red);
        set.BarColors.Add(Color.yellow);
        set.BarColors.Add(Color.green);

        // Add data set to chart data
        chartcomputing.GetChartData().DataSets.Add(set);
    }
}
