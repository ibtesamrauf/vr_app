using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

    public static String tourId = "";
    public static int count_number = 0 ;
    public static string fullPath, fullPathh;
    string realPath;
    string oriPath;
    string json;
    int dlProgress;
    int length;
    float zaaaa;
    public static string[] Videoname = new string[100];
    public static string[] Videoname1 = new string[250];
    public static string[] Videoname11 = new string[250];
    public static string[] Videoname111 = new string[250];
    public static string[] Videoname1111 = new string[250];

    public static string[] ImageCountInTour = new string[250];
    public static int v = 0;
    public static int vv = 0;
    public static int vvv = 0;
    public static int vvvv = 0;
    public static int index = 0;
    GUIStyle guiStyle;
    string log = "";
    Texture2D texture;
    WWW www;
    //private GameObject gameObject;

    void Start()
    {
        string clipBoardValue = UniClipboard.GetText();
        Splash.tourId = clipBoardValue;
        //Splash.tourId = "4";
        DownloadVideo(constants.GETVIDEOSNAME + Splash.tourId);
    }

    void Update()
    {
        //if (www == null)
        //{
        //    Debug.Log("downloading");
        //}
    }
    public void GotoNextimage()
    {
        count_number++;
    }

    public void DownloadVideo(string url)
    {
        Debug.Log(""+ url);
        StartCoroutine(Getvideonames(url));
    }

    IEnumerator Getvideonames(string videoUrl)
    {
        WWW www = new WWW(videoUrl);
        yield return www;
        json = www.text;
        if(json == null)
        {
            buttonScript.imageNameEmptyNetwork = true;
            SceneManager.LoadScene("Main_id_scene");
        }
        //Debug.Log(json);
        Getvideos(json);
    }

    [System.Serializable]
    public class MyClassVideo
    {
        public string image_path;
        public string image_path_thumbnail;
        public string scene_desc;
        public string tour_id;
        public string tour_name;
        
    }

    [System.Serializable]
    public class MyClassDataVideo
    {
        public List<MyClassVideo> result;
    }


    public void Getvideos(String names)
    {
        if(v == 0){ 
            if (v > 0)
            {
                v = 0;
                int j = 0;
                while (j != Splash.Videoname.GetLength(0))
                {
                    if (Splash.Videoname[j] != null)
                    {
                        Splash.Videoname[j] = null;
                    }
                    j++;
                }
            }
            MyClassDataVideo image_name = JsonUtility.FromJson<MyClassDataVideo>(names);


            foreach (MyClassVideo ved in image_name.result)
            {
                Videoname[v] = ved.image_path;
                Videoname1[v] = ved.image_path_thumbnail;
                Videoname11[v] = ved.scene_desc;
                Videoname111[v] = ved.tour_id;
                Videoname1111[v] = ved.tour_name;
                v++;
            }


            Debug.Log("vvvvvv" + v);

            for (int i = 0; i < v; ++i)
            {
                if (Videoname111[i] != Videoname111[i + 1])
                {
                    ImageCountInTour[vv] = "" + (i + 1);
                    vv++;
                }
            }
//            Debug.Log("aaa: " + Videoname1[index]);
            //if (Videoname[index] == null || index < -1)
            //{
            //    Videoname[index] = "";
            //    buttonScript.imageNameEmpty = true;
            //    SceneManager.LoadScene("Main_id_scene");
            //}
            //else {
            //    buttonScript.imageNameEmpty = false;
            //}
        }
        StartCoroutine(Download());
    }

    private IEnumerator ShowProgress(WWW www)
    {
        while (!www.isDone)
        {
            //Debug.Log(string.Format("Downloaded {0:P1}", www.progress));
            yield return new WaitForSeconds(.1f);
        }
        Debug.Log("Done");
    }


    IEnumerator Download()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Videoname[index] = "";
            buttonScript.imageNameEmptyNetwork = true;
            SceneManager.LoadScene("Main_id_scene");
        }

        string URL =  Videoname[index];
        URL = URL.Replace(" ", "%20");
        //string URL = "http://admin.vr.hostrayatech.com/upload_images/uploads/Ibtesam rauf last 1/2.jpg";
        // Start a download of the given URL
        www = new WWW(URL);
        Debug.Log("Download in Progress");
        StartCoroutine(ShowProgress(www));
        yield return www;
        if (string.IsNullOrEmpty(www.error))
        {
            Debug.Log("no error");
        }
        else {
            Debug.Log("" + www.error);
            StartCoroutine(Download());
            //buttonScript.imageNameEmptyNetwork = true;
            //SceneManager.LoadScene("Main_id_scene");
        }
        Debug.Log("" + www.texture);
        texture = www.texture;
        // assign texture
        Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = texture  as Texture2D;
            renderer.material.SetTextureScale("_MainTex", new Vector2(-1, 1));
        Debug.Log("Download Successful");
    }

}
public class constants
{
    public static string BASEURL = "http://138.197.141.191/";
    public static string BASEURLTWO = "http://138.197.141.191/";
    public static string GETVIDEOSNAME = BASEURL + "api-responce/"; //  + Splash.tourId 87";
}