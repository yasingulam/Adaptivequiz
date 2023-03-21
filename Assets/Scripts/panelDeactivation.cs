using UnityEngine;
using UnityEngine.UI;

public class panelDeactivation : MonoBehaviour
{
    public GameObject panel;
    public Button returnbutton;

    void Start()
    {
        returnbutton.onClick.AddListener(ClosePanel);
    }

    void ClosePanel()
    {
        panel.SetActive(false);
    }
}