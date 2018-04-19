using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class docmd : MonoBehaviour {

    public GameObject anotherObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void doPlay() {

        Debug.Log("doPlay");
        SceneManager.LoadScene("game");
    }

    public void doExit()
    {

        Debug.Log("doExit");

        sB obj = anotherObj.GetComponent<sB>();

        if (obj != null) {
            obj.show();
        }

        Application.Quit();
    }

}
