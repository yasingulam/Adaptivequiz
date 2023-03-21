using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    public Text currentuser;
    private void Start()
    {
        currentuser.text = Servers.currentusername;
    }
}
