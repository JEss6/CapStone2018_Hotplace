using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoToShelf : MonoBehaviour
{

    public void Click_to_Shelf()
    {
        SceneManager.LoadScene(8);
    }
}
