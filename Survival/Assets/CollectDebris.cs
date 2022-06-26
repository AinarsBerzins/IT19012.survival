using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDebris : MonoBehaviour
{
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wing")
        {
            //playSound.playCollectSound();
            //collectSound.Play();
            CountSystem.theDebris += 50;
            Destroy(gameObject);
        }
    }
}
