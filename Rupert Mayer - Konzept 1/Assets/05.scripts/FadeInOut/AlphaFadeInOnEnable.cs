using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaFadeInOnEnable : MonoBehaviour
{   


    Color color; 
    public float fadeSpeed;

    private float Alpha = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    color = GetComponent<Renderer>().material.color;

    color.a = Alpha;
    }

    // Update is called once per frame
    void Update()
    {
    
    if( Alpha <= 255) {

        Alpha += 1 * fadeSpeed;
        color.a = Alpha;

    }
    

    Debug.Log (color.a + "ist der Alpha Wert");

      
    }

    
}
