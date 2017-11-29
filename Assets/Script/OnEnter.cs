using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnEnter : MonoBehaviour {


    public Material inactiveMaterial;
    public Material gazedAtMaterial;
    public Image Image11;
    bool coolingDown = true;
    public float waitTime = 30.0f;


    void Start()
    {
        //startingPosition = transform.localPosition;
        SetGazedAt(false);
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (gazedAt)
        {
            
                //Debug.Log("Creating enemy number: " + i);
                //Debug.Log("ibtesam1111111" + Time.deltaTime);
                Image11.fillAmount += 1.0f / waitTime * Time.deltaTime;
            
        }
        //if (inactiveMaterial != null && gazedAtMaterial != null)
        //{
        //    GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
        //    return;
        //}
        //GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
    }


    void Update()
    {
       // Debug.Log("iiiiiiiiiiiii" + Time.time);
    }


}
