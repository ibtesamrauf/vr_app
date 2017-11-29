using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeimage : MonoBehaviour {
    public static int imageindex;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        imageindex = 0;
        SceneManager.LoadScene("zahoor_Scene");
    }
}
