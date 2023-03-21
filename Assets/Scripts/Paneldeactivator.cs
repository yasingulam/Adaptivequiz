// Import the UnityEngine.UI namespace
using UnityEngine;
using UnityEngine.UI;



// Define a public class named CloseButtonHandler that inherits from MonoBehaviour
public class Paneldeactivator : MonoBehaviour
{
    // Define a public GameObject variable named popupWindow
    public GameObject popupWindow;

    // Define a public method named OnCloseButtonPress that takes no arguments
    public void OnCloseButtonPress()
    {
        // Call the SetActive method on the popupWindow object with a value of false to hide the popup window when the close button is pressed
        popupWindow.SetActive(false);
    }
}
