using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
    public static AudioSource collectSound;

    public static void playCollectSound()
    {
        collectSound.Play();
    }
}
