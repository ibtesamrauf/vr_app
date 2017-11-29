using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

public class Splash_plane : MonoBehaviour
{
    public static int count2 = 0; 
    public int index_p;
    public Text title;
    GUIStyle guiStyle;
    string log = "";
    Texture2D texture;

    void Start()
    {
        DownloadVideo(constants_p.GETVIDEOSNAME_p + Splash.tourId);
    }

    private void Update()
    {

    }

    public void DownloadVideo(string url)
    {
        StartCoroutine(Download());
    }

    IEnumerator Download()
    {
        string URL = Splash.Videoname1[CPlaneVrSliderTourlist.imageCountArray_new[index_p]];
       // string URL = "https://s3.ca-central-1.amazonaws.com/vr-project-dev/Demo%20June%2012/thumbnail/1";
        //Debug.Log(""+ URL);
        if(URL != null)
        {
            URL = URL.Replace(" ", "%20");
          //  Debug.Log("" + URL);
        }
        // Start a download of the given URL
        WWW www = new WWW(URL);
        yield return www;
        texture = www.texture;
        // assign texture
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = texture as Texture2D;
        renderer.material.SetTextureScale("_MainTex", new Vector2(-1, 1));
        title.text = Splash.Videoname11[CPlaneVrSliderTourlist.imageCountArray_new[index_p]];
        Debug.Log("Download Successful & TEXT");
        count2++;
        if(count2 == enablePlane.count)
        {
            Debug.Log("pp");
        }
    }
}
public class constants_p
{
    public static string BASEURL_p = "http://138.197.141.191/";
    public static string BASEURLTWO_p = "http://138.197.141.191/";
    public static string GETVIDEOSNAME_p = BASEURL_p + "api-responce/";
}
