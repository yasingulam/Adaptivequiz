using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropDown : MonoBehaviour
{

    //create a public integer for the option variable,
    //this will be passed when the begin button is pressed
    public static int option;
    
   
    
    // new void to take in the integer value of the drop down menu
    public void HandleInputData(int val)
    {
        if(val == 0)// this corresponds to select a subject.
        {
            option = 0;
        }
        if (val == 1)// this corresponds to computing
        {
            option = 1;
        }
        if (val == 2)// this corresponds to maths
        {
            option = 2;
        }
        if (val == 3)// this corresponds to science
        {
            option = 3;
        }
        Debug.Log(option);
    }
    


}
