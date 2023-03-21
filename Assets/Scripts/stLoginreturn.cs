using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //This is an imported class which I will be using for navigation

public class stLoginreturn : MonoBehaviour
{
    public void stloginreturn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }


}
