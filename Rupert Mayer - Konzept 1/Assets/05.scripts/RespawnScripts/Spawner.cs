using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnObj;

    

   

    // Update is called once per frame
    void OnEnable() {

        Instantiate(spawnObj, spawnPos.position, spawnObj.transform.rotation, spawnPos );
        
    }
}
