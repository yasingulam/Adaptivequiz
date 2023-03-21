using UnityEngine;
using UnityEngine.UI;

public class panelActivation : MonoBehaviour
{
    public GameObject panel;
    public Button openButton;
    public Button closeButton;

    void Start()
    {
        openButton.onClick.AddListener(ActivatePanel);
        closeButton.onClick.AddListener(ClosePanel);
    }

    void ActivatePanel()
    {
        panel.SetActive(true);
    }

    void ClosePanel()
    {
        panel.SetActive(false);
    }
}