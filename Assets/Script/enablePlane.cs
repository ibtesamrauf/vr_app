using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enablePlane : MonoBehaviour {
    public static int count = 0;
    // Use this for initialization
    void Start () {

        int j = 0;
        if (count > 0)
        {
            count = 0;
            Debug.Log("count to zero" + count);
        }
        while (j != Splash.Videoname.GetLength(0))
        {
            if (Splash.Videoname[j] != null)
            {
                count++;
            }
            j++;
        }
        count = CPlaneVrSliderTourlist.countAfterImage;
        Debug.Log("count " + count);
        for (int i = 1; i <= 24; i++)
        {
            if (i > count)
            {
                if (count < 7)
                {
                    Slider sliderBar2 = GameObject.Find("Slider (1)").GetComponent<Slider>();
                    sliderBar2.transform.Translate(Vector3.up * 180);
                }
                if (count < 13)
                {
                    Slider sliderBar3 = GameObject.Find("Slider (2)").GetComponent<Slider>();
                    sliderBar3.transform.Translate(Vector3.up * 180);
                }
                if (count < 19)
                {
                    Slider sliderBar3 = GameObject.Find("Slider (3)").GetComponent<Slider>();
                    sliderBar3.transform.Translate(Vector3.up * 180);
                }
                GameObject respawn = GameObject.FindWithTag("" + i);
                respawn.SetActive(false);

                GameObject enableImageName = GameObject.FindWithTag("title" + i);
                enableImageName.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
