using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFogScript : MonoBehaviour
{   

    public float offsetTime;
    public float duration; 

    public float NewFogDensity;

    public Color NewFogCol;
    private Color FogCol;
    private float FogDens;
    private float counter = 0;
    // Start is called before the first frame update
   void Start()
    {
      FogCol = RenderSettings.fogColor;
      FogDens = RenderSettings.fogDensity;
      
    }
    void onEnable() {
        counter = 0;
        RenderSettings.fogColor = FogCol;
        RenderSettings.fogDensity = FogDens;
        
    }
    void Update() {
        counter = counter + Time.deltaTime;
        if (counter >= offsetTime && counter <= offsetTime + duration) {

            RenderSettings.fogColor = NewFogCol;
            RenderSettings.fogDensity = NewFogDensity;

        } else {

            RenderSettings.fogColor = FogCol;
            RenderSettings.fogDensity = FogDens;
        }



    }
        

    
}
