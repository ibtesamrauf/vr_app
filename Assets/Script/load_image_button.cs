using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class load_image_button : MonoBehaviour {


    public void LoadImage()
    {
        Debug.Log("cLICK");
        //Call the actual loading method
        StartCoroutine(RealLoadImage());
    }

    //This is where the actual code is executed
    private IEnumerator RealLoadImage()
    {
        Debug.Log("Start loading");
        //A URL where the image is stored
        string url = "https://s-media-cache-ak0.pinimg.com/originals/b4/03/10/b403102b477fd3694aa8587afe4013bd.png";

        //Call the WWW class constructor
        WWW imageURLWWW = new WWW(url);

        //Wait for the download
        yield return imageURLWWW;

        //Simple check to see if there's indeed a texture available
        if (imageURLWWW.texture != null)
        {

            //Construct a new Sprite
            Sprite sprite = new Sprite();

            //Create a new sprite using the Texture2D from the url. 
            //Note that the 400 parameter is the width and height. 
            //Adjust accordingly
            sprite = Sprite.Create(imageURLWWW.texture, new Rect(0, 0, 200,200), Vector2.one);

            //Assign the sprite to the Image Component
            GetComponent<UnityEngine.UI.Image>().sprite = sprite;
        }

        yield return null;

        Debug.Log("Download Done");
    }
}
