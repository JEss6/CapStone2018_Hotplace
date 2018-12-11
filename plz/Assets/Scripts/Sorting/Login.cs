using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Login : MonoBehaviour {

    public InputField nameField;
    public InputField passwordField;
    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }


    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();

        form.AddField("checkname", nameField.text);
       

        //Debug.Log(nameField.text);

        WWW www = new WWW("http://wldbs1993.cafe24.com/loginplzcafe.php", form);
        yield return www;

        Debug.Log(www.text.Length);
        if (!(www.text.Length>13)) 
        {
            Debug.Log(www.text.Substring(0, 9) + "&" + "Mistmatch");
            Debug.Log("SUccess!");
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);

        }

        if ((www.text.Length > 13)) 
        {
            Debug.Log("user login fail");
        }
    }
    public void VerifyInputs()
        {
            submitButton.interactable = (nameField.text.Length >= 1);
        }



}
