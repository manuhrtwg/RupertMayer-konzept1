﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIGHTpulse : MonoBehaviour
{
    // Start is called before the first frame update
    private Light myLight;
     public float maxIntensity = 4f;
     public float minIntensity = 2f;
     public float pulseSpeed = 0.8f; //here, a value of 0.5f would take 2 seconds and a value of 2f would take half a second
     private float targetIntensity = 1f;
     private float currentIntensity;    
     
     
     void Start(){
         myLight = GetComponent<Light>();
     }    
     void Update(){
         currentIntensity = Mathf.MoveTowards(myLight.intensity,targetIntensity, Time.deltaTime*pulseSpeed);
         if(currentIntensity >= maxIntensity){
             currentIntensity = maxIntensity;
             targetIntensity = minIntensity;
         }else if(currentIntensity <= minIntensity){
             currentIntensity = minIntensity;
             targetIntensity = maxIntensity;
         }
         myLight.intensity = currentIntensity;
     }
}
