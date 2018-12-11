﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sofa : MonoBehaviour
{

    public InputField widthField;
    public InputField lengthField;
    public InputField heightField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(sofasize());
    }

    IEnumerator sofasize()
    {
        WWWForm form = new WWWForm();

        form.AddField("sw",widthField.text);
        form.AddField("sl",lengthField.text);
        form.AddField("sh",heightField.text);



        Debug.Log(widthField.text);
        Debug.Log(lengthField.text);
        Debug.Log(heightField.text);

        Debug.Log(form);
        Debug.Log(form.data);
        Debug.Log(form.data.Length);


        WWW www = new WWW("http://wldbs1993.cafe24.com/sofa.php", form);
        yield return www;

        Debug.Log(www.text);

        if (www.text == "0 result")

        {

            Debug.Log("faill");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);

        }

        else
        {

            Debug.Log("successfully");
           
        }

    }

    public void VerifyInputs()
    {

        submitButton.interactable = (widthField.text.Length >= 0);


    }

}
