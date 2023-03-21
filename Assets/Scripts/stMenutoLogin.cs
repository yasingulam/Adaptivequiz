using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stMenutoLogin : MonoBehaviour
{
    public void stmenutologin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -2);
        Servers.currentusername = "";
    }

}
