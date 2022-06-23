using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteroidField : MonoBehaviour
{
    public Transform asteroidPrefab;
    public int fieldRadius = 500;
    public int asteroidCount = 1000;

    void Start()
    {
        for (int loop = 0; loop < asteroidCount; loop++){
            Transform temp = Instantiate(asteroidPrefab, Random.insideUnitSphere * fieldRadius, Random.rotation);
            temp.localScale = temp.localScale * Random.Range(0.05f, 1);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
