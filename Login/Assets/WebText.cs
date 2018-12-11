using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebText : MonoBehaviour {
    




	IEnumerator Start () {

        WWW request = new WWW("http://localhost/webtest.php");

        yield return request;

        Debug.Log(request.text);


		
	}
	
	
}
