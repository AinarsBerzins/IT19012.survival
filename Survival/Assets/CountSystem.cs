using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountSystem : MonoBehaviour
{
    public GameObject DebrisText;
    public static int theDebris;
    //public AudioSource collectSound;

    private void Update()
    {
        DebrisText.GetComponent<Text>().text = "Debris: " + theDebris;
    }
}
