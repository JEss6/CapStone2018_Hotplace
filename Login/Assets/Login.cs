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
       

        Debug.Log(nameField.text);
        Debug.Log(form);
        Debug.Log(form.data);
        Debug.Log(form.data.Length);


        WWW www = new WWW("http://localhost/size.php", form);
        yield return www;

        Debug.Log(www.text);
        if (www.text != "Mismatch\n\n\n") 

        {
           
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);




        }

        if (www.text == "Mistmatch\n\n\n") 
        {
            Debug.Log("user login fail");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            
        }


    }
    public void VerifyInputs()
        {

            submitButton.interactable = (nameField.text.Length >= 1);


        
   }



}
