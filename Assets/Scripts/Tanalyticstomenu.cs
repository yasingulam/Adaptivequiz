using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tanalyticstomenu : MonoBehaviour
{
    public void tAnalyticstomenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);

    }

}

