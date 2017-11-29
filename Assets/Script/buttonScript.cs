using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour {
    public static bool imageNameEmpty = false;
    public static bool imageNameEmptyNetwork = false;
    public InputField Field;
    public Text ErrorText;
    public void OnPointerClick()
    {
        string fieldText = Field.text , tourIdTemp = "";
        int count = fieldText.Length;
        
        char[] characters = fieldText.ToCharArray();
        for (int k = 0; k < count; k++)
        {
            if(k > 4)
            {
                tourIdTemp += characters[k];
            }
        }
        
        Splash.tourId = tourIdTemp;
        if (Splash.tourId != "")
        {
            SceneManager.LoadScene("zahoor_Scene");
        }
        
    }

    void Update()
    {
        if(imageNameEmpty == true)
        {
            ErrorText.text = "Invalid Code";
        }
        else if (imageNameEmptyNetwork == true)
        {
            ErrorText.text = "Network Error";
        }
    }
}
