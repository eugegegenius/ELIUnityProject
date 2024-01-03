using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightChange : MonoBehaviour
{
    public Light myLight;
    public bool changeIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 20.0f;
    public bool repeatIntensity = false;
    private float startTime;
    
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (changeIntensity)
        {
            if (repeatIntensity)
            {
                myLight.GetComponent<Light>().intensity = 1 + 0.00001f * Time.time;
            }
            else
            {
                myLight.GetComponent<Light>().intensity = Time.time * intensitySpeed;
                if (myLight.GetComponent<Light>().intensity >= maxIntensity)
                {
                    changeIntensity = false;
                }
            } 
 
        }

    }
}
