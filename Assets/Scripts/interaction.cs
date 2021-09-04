using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public GameObject sphere_1;
    public GameObject sphere_2;

    public AudioSource Audio;
    public AudioClip sound_1;
    public AudioClip sound_2;

    bool spinSp2 = false;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "sp_1")
                {
                    onClickSp1();
                }

                if (hit.transform.name == "sp_2")
                {
                    onClickSp2();
                }
            }
        }

        if(spinSp2)
        {
            //Rotate sphere Y AXIS
            sphere_2.transform.Rotate(0f, 100f * Time.deltaTime, 0f, Space.Self);
        }
    }

    public void onClickSp1()
    {
        Audio.PlayOneShot(sound_1);
        //Below line will chnage material color to new Random color
        sphere_1.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }

    public void onClickSp2()
    {
        Audio.PlayOneShot(sound_2);
        spinSp2 = !spinSp2;
    }
}
