using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VrSliderBack : MonoBehaviour {

    public static bool check1;

    public float fillTime = 2f;

    public Slider mySlider;
    public GameObject gameObjects;
    private float timer;
    private bool gazedAt;
    private Coroutine fillBarRoutine;

    // Use this for initialization
    void Start()
    {
        Slider planeNumbers;
        planeNumbers = GameObject.Find("Slider").GetComponent<Slider>();
        mySlider = planeNumbers;
        gameObjects = GetComponent<GameObject>();
        // mySlider = GetComponent<Slider>();
        if (mySlider == null) Debug.Log("Please add a slider component to this gameobject");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PointerEnter1()
    {
        gazedAt = true;
        fillBarRoutine = StartCoroutine(FillBar());

        if (check1)
        {
            gazedAt = true;
            fillBarRoutine = StartCoroutine(FillBar());
        }

    }

    public void PointerExit1()
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
        //CPlaneVrSliderTourlist.count = 0;
        CPlaneVrSliderTourlist.imageCountArray_new = new int[50];
        CPlaneVrSliderTourlist.imageCountArray = new int[50];
        CPlaneVrSliderTourlist.countAfterImage = 0;
        Debug.Log("back");
        SceneManager.LoadScene("tour_list");
    }

}
