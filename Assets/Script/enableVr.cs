using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class enableVr : MonoBehaviour {

    Ray ray;
    RaycastHit hit;

    // Use this for initialization
    void Start () {
        //enableVrMethod();
        //Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    //IEnumerator LoadDevice(string newDevice, bool enable)
    //{
    //    VRSettings.LoadDeviceByName(newDevice);
    //    yield return null;
    //    VRSettings.enabled = enable;
    //    Debug.Log("Vr Enable");
    //}

    //void enableVrMethod()
    //{
    //    StartCoroutine(LoadDevice("Cardboard", true));
    //}

    //void disableVr()
    //{
    //    StartCoroutine(LoadDevice("", false));
    //}

    // Update is called once per frame
    void Update () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("  hitted at : " + hit.collider.name);
        }
    }
}
