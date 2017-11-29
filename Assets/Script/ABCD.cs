using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABCD : MonoBehaviour
{

    ////public static int countAfterImage = 0;
    ////public static int[] imageCountArray = new int[50];
    ////public static int[] imageCountArray_new = new int[50];
    //void Start()
    //{
    //    //countAfterImage = ((Splash.v - 1) - (int.Parse(Splash.ImageCountInTour[Splash.index]) - 1)) + 1;
    //    //Debug.Log("count_after_image : " + countAfterImage);

    //    //for (int j = (int.Parse(Splash.ImageCountInTour[Splash.index]) - 1); j <= (Splash.v - 1); j++)
    //    //{
    //    //    imageCountArray[j] = j;
    //    //    //Debug.Log("Splash.Videoname1111 title = " + Splash.Videoname11[j]);
    //    //}
    //    //int count = 0;

    //    //foreach (int value in imageCountArray)
    //    //{
    //    //    if (value.Equals(0))
    //    //    {

    //    //    }
    //    //    else
    //    //    {
    //    //        //Debug.Log("count = " + count);
    //    //        imageCountArray_new[count] = value;
    //    //        count += 1;
    //    //    }
    //    //}

    //    //for (int j = 0; j < countAfterImage; j++)
    //    //{
    //    //    Debug.Log("value tttt = " + imageCountArray_new[j]);
    //    //}

    //}

    //void Update()
    //{
    //    SetFixedY(5.0f);
    //}
    ////public GameObject other;
    ////public Camera cam = other.GetComponent<Camera>();
    //void SetFixedY(float n)
    //{
    //    //transform.position = new Vector3(transform.position.x, n, transform.position.z);
    //    //transform.position.x = player.transform.position.x;
    //    //cam.main.transform.position.y = 2.0;
    //}



    //public GameObject player;       //Public variable to store a reference to the player game object


    //private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    //// Use this for initialization
    //void Start()
    //{
    //    //Calculate and store the offset value by getting the distance between the player's position and camera's position.
    //    offset = transform.position - player.transform.position;
    //}

    //// LateUpdate is called after Update each frame
    //void LateUpdate()
    //{
    //    // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
    //    transform.position = player.transform.position + offset;
    //}


 void Update()
    {

        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);

    }
}
