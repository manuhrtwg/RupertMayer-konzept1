using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationReset : MonoBehaviour
{
    // Start is called before the first frame update
    
    Vector3 OrigPos;
    
   
    void Awake()
    {
      
      OrigPos = transform.position;
       

    }

    // Update is called once per frame
   void OnEnable () {

       transform.position = OrigPos;
       Debug.Log("Originale Position: " + OrigPos);
   }

  
}
