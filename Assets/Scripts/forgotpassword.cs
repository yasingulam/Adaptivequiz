using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forgotpassword : MonoBehaviour
{

    public InputField forgotpasswordField;
    public Text statustext;
    public Button checkButton;

    public void Startforgotpassword()
    {
        StartCoroutine(Forgotpassword());
    }
    //  This essentially all allows us to set up the buttons and call a function which will be able to access the localhost link,

    IEnumerator Forgotpassword()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", forgotpasswordField.text);//sends this data from the input field to the form thats bewing passed to the php script
 

        WWW www = new WWW("http://localhost/unity/Register/retreivepassword.php", form);// this is used to access the directory of the PHP file so its contents can be acccessed.
        yield return www;// returns a response so that the rest of code can continue to run
        if (www.text != "0")
        {
            Debug.Log("reteived password");// if there is no error returned from the php script
            statustext.text = ("The password is: "+ www.text);//If the password is found,it will return the form with the corresponding value from the PHP

        }// returns text from the PHP info
        else
        {
            Debug.Log("failed to retreive password");// if the error is present(>0) then say this
            statustext.text = "retreive password failed";

        }
        www.Dispose();

    }


}