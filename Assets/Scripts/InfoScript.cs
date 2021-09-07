using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class InfoScript : MonoBehaviour
{
 
    public static Camera camera;
    public Camera cam1;
    public Text t;
    public Image i;

    static bool detection = false;
 

    public static ARTrackedImageManager aRTrackedImageManager;
    public ARTrackedImageManager mang;

    void Start()
    {
        aRTrackedImageManager = mang;
        camera = cam1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!detection && aRTrackedImageManager.trackables.count == 1)
        {
            detection = true;
            i.gameObject.SetActive(false);
            t.gameObject.SetActive(false);
        }
    }

   
}
