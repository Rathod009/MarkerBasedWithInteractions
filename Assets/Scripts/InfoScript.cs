using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class InfoScript : MonoBehaviour
{
    public static Text infoTxt;
    public static Image img;

    public Text t;
    public Image i;

    static bool detection = false;
    static bool tapOn1 = false;
    static bool tapOn2 = false;

    public static ARTrackedImageManager aRTrackedImageManager;
    public ARTrackedImageManager mang;

    void Start()
    {
        infoTxt = t;
        img = i;
        aRTrackedImageManager = mang;
    }

    // Update is called once per frame
    void Update()
    {
        if (!detection && aRTrackedImageManager.trackables.count == 1)
        {
            detection = true;
            infoTxt.text = "Image is tracked! Click on coloured sphere to change color";
        }
    }

    public static void SP1()
    {
        if (!tapOn1)
        {
            tapOn1 = true;
            infoTxt.text = "Click on other sphere to rotate it! First Click will rotate it and second click will stop it";
        }
    }

    public static void SP2()
    {
        if (!tapOn2)
        {
            infoTxt.gameObject.SetActive(false);
            tapOn2 = true;
            img.gameObject.SetActive(false);
        }
    }
}
