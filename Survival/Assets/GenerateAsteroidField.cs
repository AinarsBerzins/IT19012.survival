using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteroidField : MonoBehaviour
{
    public Transform rockPrefab;
    public int fieldRadius = 500;
    public int asteroidCount = 1000;

    void Start()
    {
        for (int loop = 0; loop < asteroidCount; loop++){
            Transform temp = Instantiate(rockPrefab, Random.insideUnitSphere * fieldRadius, Random.rotation);
            temp.localScale = temp.localScale * Random.Range(0.05f, 1);
        }
    }

    void Update()
    {
        
    }
}
