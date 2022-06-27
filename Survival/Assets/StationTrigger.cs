using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationTrigger : MonoBehaviour
{
    public static int life = 1000;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            life -= 1;
            if (life <= 0) die();
        }
        if (other.gameObject.tag == "Asteroid")
        {
            life -= 100;
            if (life <= 0) die();
        }
    }

    private void die()
    {
        Destroy(gameObject);
    }
}
