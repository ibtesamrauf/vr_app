using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mousdown : MonoBehaviour {

    public void OnMouseDown()
    {
        //Splash.index++;
        SceneManager.LoadScene("index");
        Debug.Log("ibtesam");
    }
}
