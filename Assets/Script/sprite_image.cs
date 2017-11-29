using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_image : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(loadScript());
	}


    IEnumerator loadScript()
    {
        string URL = "http://www.wildnatureimages.com/images%203/San-Diego-Panoramic-Print..jpg";

        var www = new WWW(URL);

        yield return www;

        Texture2D texture = new Texture2D(1, 1);
        www.LoadImageIntoTexture(texture);

        Sprite sprite = Sprite.Create(texture,
            new Rect(0, 0, 200, 200),
            Vector2.one);
        GetComponent<SpriteRenderer>().sprite = sprite;

    }

}
