using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class CPlaneVrSliderTourlist : MonoBehaviour {

    public static int countAfterImage = 0;
    public static int[] imageCountArray = new int[50];
    public static int[] imageCountArray_new = new int[50];
    public static int count2222 = 0;
    public static bool check;

    public float fillTime = 2f;

    public Slider mySlider;

    private float timer;
    private bool gazedAt;
    private Coroutine fillBarRoutine;
    static int index_p_Back = 0;

    // Use this for initialization
    void Start()
    {
        Slider planeNumbers;
        if (gameObject.CompareTag("1") || gameObject.CompareTag("2") || gameObject.CompareTag("3") || gameObject.CompareTag("4") || gameObject.CompareTag("5") || gameObject.CompareTag("6"))
        {
            planeNumbers = GameObject.Find("Slider").GetComponent<Slider>();
            mySlider = planeNumbers;
        }
        if (gameObject.CompareTag("7") || gameObject.CompareTag("8") || gameObject.CompareTag("9") || gameObject.CompareTag("10") || gameObject.CompareTag("11") || gameObject.CompareTag("12"))
        {
            planeNumbers = GameObject.Find("Slider (1)").GetComponent<Slider>();
            mySlider = planeNumbers;
        }
        if (gameObject.CompareTag("13") || gameObject.CompareTag("14") || gameObject.CompareTag("15") || gameObject.CompareTag("16") || gameObject.CompareTag("17") || gameObject.CompareTag("18"))
        {
            planeNumbers = GameObject.Find("Slider (2)").GetComponent<Slider>();
            mySlider = planeNumbers;
        }
        if (gameObject.CompareTag("19") || gameObject.CompareTag("20") || gameObject.CompareTag("21") || gameObject.CompareTag("22") || gameObject.CompareTag("23") || gameObject.CompareTag("24"))
        {
            planeNumbers = GameObject.Find("Slider (3)").GetComponent<Slider>();
            mySlider = planeNumbers;
        }

        //Debug.Log("index_p_Back :"+ index_p_Back);

        if (mySlider == null) Debug.Log("Please add a slider component to this gameobject");
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }

    public void PointerEnter()
    {
        gazedAt = true;
        fillBarRoutine = StartCoroutine(FillBar());

        if (check)
        {
            gazedAt = true;
            fillBarRoutine = StartCoroutine(FillBar());
        }

    }

    public void PointerExit()
    {
        gazedAt = false;
        if (fillBarRoutine != null)
        {
            StopCoroutine(fillBarRoutine);
        }

        timer = 0f;
        mySlider.value = 0f;
    }

    private IEnumerator FillBar()
    {
        timer = 0f;

        while (timer < fillTime)
        {
            timer += Time.deltaTime;

            mySlider.value = timer / fillTime;

            yield return null;

            if (gazedAt)
                continue;

            timer = 0f;
            mySlider.value = 0f;
            yield break;
        }

        OnBarFilled();
    }

    private void OnBarFilled()
    {
        if(count2222 != null)
        {
            count2222 = 0;
        }
        index_p_Back = GetComponent<Splash_plane>().index_p;
        Debug.Log("index_p_Back value : " + index_p_Back);
        Splash.index = index_p_Back;
        Debug.Log("Splash.ImageCountInTour = " + (int.Parse(Splash.ImageCountInTour[Splash.index]) - 1));
        Debug.Log("Splash.v = " + (Splash.v) );

        
        if (Splash.index == 0)
        {
            
            countAfterImage = ((int.Parse(Splash.ImageCountInTour[Splash.index])));
            Debug.Log("count_after_image : " + countAfterImage);
            if (enableplaneTourlist.count == 1)
            {
                for (int j = 0; j < (int.Parse(Splash.ImageCountInTour[Splash.index])); j++)
                {
                    imageCountArray[j] = j;
                    //Debug.Log("Splash.Videoname1111 title = " + Splash.Videoname11[j]);
                }
            }
            else
            {
                for (int j = 0; j <= (int.Parse(Splash.ImageCountInTour[Splash.index])); j++)
                {
                    imageCountArray[j] = j;
                    //Debug.Log("Splash.Videoname1111 title = " + Splash.Videoname11[j]);
                }
            }
            
        }
        else
        {
            Debug.Log("Splash.ImageCountInTour = " + (int.Parse(Splash.ImageCountInTour[Splash.index - 1]) - 1));
            countAfterImage = ((int.Parse(Splash.ImageCountInTour[Splash.index]) - 1) - (int.Parse(Splash.ImageCountInTour[Splash.index - 1]) - 1));
            Debug.Log("count_after_image : " + countAfterImage);
            for (int j = (int.Parse(Splash.ImageCountInTour[Splash.index - 1 ])); j <= (int.Parse(Splash.ImageCountInTour[Splash.index]) - 1) ; j++)
            {
                imageCountArray[j] = j;
                Debug.Log("Splash.Videoname1111 title = " + j);
            }
        }
        
        

        foreach (int value in imageCountArray)
        {
            if (value.Equals(0))
            {

            }
            else
            {
                Debug.Log("count = " + count2222);
                imageCountArray_new[count2222] = value;
                count2222 += 1;
            }
        }

        for (int j = 0; j < countAfterImage; j++)
        {
            Debug.Log("value tttt = " + imageCountArray_new[j]);
        }
        
        SceneManager.LoadScene("index");
    }

}