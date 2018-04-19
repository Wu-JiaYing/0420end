using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class sB : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void show() {

        EditorUtility.DisplayDialog("title", "message", "ok");
    }
}
