using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineRotate : MonoBehaviour
{

    public GameObject rotationObj; 
    public bool RotOnOff = false; 
    public float RotSpeed = 1;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RotOnOff) {
            RotSpeed += 1;
        }

        rotationObj.transform.Rotate(0f,1f * RotSpeed, 0f);
        
       
    }
}
