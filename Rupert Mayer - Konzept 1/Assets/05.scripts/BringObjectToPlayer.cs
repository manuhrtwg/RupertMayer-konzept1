namespace VRTK.Examples

{

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BringObjectToPlayer : MonoBehaviour
{   

   
    private Transform transformObj; 
    private Vector3 origin;
    private Vector3 playerPosVector;

    public GameObject playerPos;
   
    // Start is called before the first frame update
    void Start()
    {

     transformObj = GetComponent<Transform>();  
     origin = transformObj.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(origin + " das ist der origin");
    }

    protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
        {
           playerPosVector = playerPos.GetComponent<Transform>().position;
          transform.position = playerPosVector;
        }

        protected virtual void InteractableObjectUnused(object sender, InteractableObjectEventArgs e)
        {
           
        }
      
    
}

}