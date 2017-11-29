using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checktexture : MonoBehaviour {

    Texture2D texture;
    string URL;

    void OnMouseDown()
    {
        Debug.Log("ibtesam");
        StartCoroutine(Download());
    }

    IEnumerator Download()
    {
        URL = "https://www.cleverfiles.com/howto/wp-content/uploads/2016/08/mini.jpg";
            //= URL.Replace(" ", "%20");
        //string URL = "http://admin.vr.hostrayatech.com/upload_images/uploads/Ibtesam rauf last 1/2.jpg";
        // Start a download of the given URL
        WWW www = new WWW(URL);
        Debug.Log("Download in Progress");

        yield return www;

        texture = www.texture;
        // assign texture
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = texture as Texture2D;
        renderer.material.SetTextureScale("_MainTex", new Vector2(-1, 1));
        Debug.Log("Download Successful");
    }
}
