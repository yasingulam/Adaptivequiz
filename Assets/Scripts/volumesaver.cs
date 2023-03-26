// This script is used to save and load a volume setting using PlayerPrefs. It is assumed that there is a UI slider that controls the volume.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumesaver : MonoBehaviour
{
    // Reference to the UI slider that controls the volume.
    public Slider volumeslider;

    public void Start()
    {
        volumeslider.value = 100;
    }
   
    
    
    // This method is called when the "save volume" button is clicked.
    public void savevolumebutton()
    {
        // Get the current value of the slider.
        float volumevalue = volumeslider.value;

        // Save the value of the slider using PlayerPrefs, with the key "volumevalue".
        PlayerPrefs.SetFloat("volumevalue", volumevalue);

        // Call the loadvalues() method to update the volume slider and audio listener with the saved value.
        loadvalues();
    }

    // This method is called to load the saved volume value and update the volume slider and audio listener accordingly.
    void loadvalues()
    {
        // Get the saved volume value from PlayerPrefs using the key "volumevalue".
        float volumevalue = PlayerPrefs.GetFloat("volumevalue");

        // Set the value of the volume slider to the saved volume value.
        volumeslider.value = volumevalue;

        // Update the volume of the AudioListener (the component that controls the global volume of the scene) with the saved volume value.
        AudioListener.volume = volumevalue;
    }
}
