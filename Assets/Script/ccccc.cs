using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccccc : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(loadSpriteIMG());
    }
    public Cubemap texture;
    public IEnumerator loadSpriteIMG()
    {
        //string URL = "http://www.easypano.com/images/pw/v3/banner.jpg";

        string URL = "http://admin.vr.hostrayatech.com/upload_images/uploads/Ibtesam rauf last 1/1.jpg";

        URL = URL.Replace(" ", "%20");

        if (Application.internetReachability == NetworkReachability.NotReachable)
            yield return null;
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Cache-Control", "no-cache");
        headers.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36");
        headers.Add("Postman-Token", "163476fc-5220-d299-7b91-8fbe5fa24cad");
        headers.Add("Accept", "*/*");
        headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        headers.Add("Accept-Language", "en-US,en;q=0.8,ja;q=0.6");
        // Start a download of the given URL
        var www = new WWW (URL);
        Debug.Log("Download in Progress");
        yield return www;

        if (string.IsNullOrEmpty(www.text))
            Debug.Log("Download Fail");
        else
        {
            Debug.Log("Download Successful");

            Texture2D texture = new Texture2D(1, 1);
            //            var texture : Cubemap = new Cubemap (128, TextureFormat.ARGB32, false);

            //texture = new Cubemap(128, TextureFormat.RGBA32, false);
    //renderer.material.mainTexture = texture;
            // assign texture
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = www.texture;
        }
        // Wait for download to complete
        yield return www;

        
    }
}
