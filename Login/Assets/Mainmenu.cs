using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour {



    public Text playDisplay;
	
    private void Start()
    {

        if (DBManager.LoggedIn)
        {

            playDisplay.text = " user: " + DBManager.username;
        }

    }



    public void GoToRegister()
    {

        SceneManager.LoadScene(1);


    }


    public void GoToLogin()
    {
        SceneManager.LoadScene(2);

    }


       

}
