using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filll : MonoBehaviour {
    public Material gameObject;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        float revealOffset = (float)(Time.timeSinceLevelLoad % 10) / 10.1F;

        gameObject.SetFloat("_Cutoff", revealOffset);

    }
}
