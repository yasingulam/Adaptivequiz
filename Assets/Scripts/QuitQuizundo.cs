using UnityEngine;
using UnityEngine.UI;

public class QuitQuizundo:MonoBehaviour
{
    public GameObject panel; // reference to the panel game object

    // method to close the panel
    public void ClosePanel()
    {
        panel.SetActive(false); // set the panel game object to inactive
    }
}