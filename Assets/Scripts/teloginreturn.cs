using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //This is an imported class which I will be using for navigation

public class teloginreturn : MonoBehaviour
{
    public void teLoginreturn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }


}
