using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadImage : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(loadSpriteIMG());	
	}

    public IEnumerator loadSpriteIMG()
    {
        //string URL = "http://media02.hongkiat.com/panoramic_photos/night_panorama_nyc.jpg";

        string URL = "http://admin.vr.hostrayatech.com/upload_images/uploads/Ibtesam%20rauf%20last%201/1.jpg";

        if (Application.internetReachability == NetworkReachability.NotReachable)
            yield return null;
        
        // Start a download of the given URL
        var www = new WWW(URL);
        Debug.Log("Download in Progress");
        yield return www;

        if (string.IsNullOrEmpty(www.text))
            Debug.Log("Download Fail");
        else
        {
            Debug.Log("Download Successful");

            Texture2D texture = new Texture2D(1 , 1);
            www.LoadImageIntoTexture(texture);
            Sprite sprite = Sprite.Create(texture,new Rect(0 , 0 , texture.width, texture.height),Vector2.one/2);

            GetComponent<SpriteRenderer>().sprite = sprite;
        }
        // Wait for download to complete
        yield return www;

        // assign texture
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = www.texture;
    }
}
