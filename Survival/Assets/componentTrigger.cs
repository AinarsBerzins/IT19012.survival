using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentTrigger : MonoBehaviour
{
    public GameObject UIpanel;
    
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag != "Rock") {
            UIpanel.SetActive(true);
        }        
    }
}
