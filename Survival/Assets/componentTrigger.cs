using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Asteroid") {
            //Destroy(other.gameObject);
        }        
    }
}
