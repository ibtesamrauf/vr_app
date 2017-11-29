using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.UI;


public class disableVr : MonoBehaviour {
    public InputField Field;
    public Text textVar;
    private static PropertyInfo m_systemCopyBufferProperty = null;
    // Use this for initialization
    void Start () {
        disableVrMtthod();
        string clipBoardValue = UniClipboard.GetText();
        if (clipBoardValue != null)
        {
            //EditorGUIUtility
            //Field.text = GUIUtility.systemCopyBuffer;
            Field.text = clipBoardValue;
        }
        else
        {
            textVar.text = "Press Vr button again from website";
        }
    }

    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        VRSettings.LoadDeviceByName(newDevice);
        yield return null;
        VRSettings.enabled = enable;
        Debug.Log("Vr disable");
//        String a = clipBoard[get];
        String aa = GUIUtility.systemCopyBuffer;
        Debug.Log("Vr disable: Str " + aa);
    }

    public static string clipBoard
    {
        get { return GUIUtility.systemCopyBuffer; }
        set { GUIUtility.systemCopyBuffer = value; }
    }

    //void enableVrMethod()
    //{
    //    StartCoroutine(LoadDevice("Cardboard", true));
    //}

    void disableVrMtthod()
    {
        StartCoroutine(LoadDevice("", false));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
