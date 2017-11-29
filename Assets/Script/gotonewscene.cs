using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotonewscene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void click()
    {
        SceneManager.LoadScene("index");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
