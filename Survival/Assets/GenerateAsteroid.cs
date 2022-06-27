using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteroid : MonoBehaviour
{
    public Transform asteroidPrefab;
    public int fieldRadius = 500;
    public float respawnTime = 1.0f;
    public static int life = 100;

    void Start()
    {
        StartCoroutine(spawnAsteroids());
    }

    IEnumerator spawnAsteroids()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnAsteroid();
        }
    }

    private void spawnAsteroid()
    {
        Transform temp = Instantiate(asteroidPrefab, Random.onUnitSphere * fieldRadius, Random.rotation);
        temp.localScale = temp.localScale * Random.Range(3.0f, 5.0f);
    }
}
