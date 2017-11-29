using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnLook : MonoBehaviour {
    public Image Image11;
    public bool coolingDown;
    public float waitTime = 30.0f;

    bool check = false;
    public void OnMouseDown()
    {
        if (coolingDown == true)
        {
            //Reduce fill amount over 30 seconds
            Image11.fillAmount += 1.0f / waitTime * Time.deltaTime;
        }
        Debug.Log("ibtesam");
    }

    public void OnMouseEnter()
    {

        Debug.Log("ibetsam enter");
        check = true;
    }
    public void OnMouseExit()
    {
        Debug.Log("ibtesam over");
        Image11.fillAmount = 0;
        check = false;
    }

    void Update()
    {
        if (check)
        {
            Image11.fillAmount += 1.0f / waitTime * Time.deltaTime;
            Debug.Log("iiiiiiiiiiiii" + Time.time);
        }

    }


}
