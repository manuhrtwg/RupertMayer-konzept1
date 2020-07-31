using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationReset : MonoBehaviour
{
    // Start is called before the first frame update
    
    Vector3 OrigPos;
    private bool enabledObj = false;
    private Animator Anim;
    private int counter = 0;

   
   
    void Awake()
    {
      
      OrigPos = transform.localPosition;
      Anim = GetComponent<Animator>();
      counter += 1;       

    }

  void OnEnable() {

    enabledObj = true;
    

  }
  
   void LateUpdate () {

    if (enabledObj && counter > 1 ) {
      
      transform.localPosition = OrigPos;
      enabledObj = false;

      Anim.Play("MayerBackward");

     
    }
    
       
   }

  
}
