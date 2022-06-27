using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidTrigger : MonoBehaviour
{
    public Transform rockPrefab;
    public int fieldRadius = 10;
    public int asteroidCount = 3;

    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.tag == "Wing")
        {
            generateRocksOnDie();
            Destroy(gameObject);
        }        
    }

    private void generateRocksOnDie()
    {
        for (int loop = 0; loop < asteroidCount; loop++)
        {
            Transform temp = Instantiate(rockPrefab, this.transform.position, Random.rotation);
            temp.localScale = temp.localScale * Random.Range(0.05f, 1);
        }
    }
}
