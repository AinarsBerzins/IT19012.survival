using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    public Transform[] bulletSpawner;
    public GameObject bulletPrefab;

    private float bulletSpeed = 100;
    private float minDelay = 0.05f;
    private float maxDelay = 0.08f;
    private bool isFiring = false;

    void Update()
    {
        if (Input.GetMouseButton(0) && isFiring == false)
        {
            isFiring = true;
            StartCoroutine(shoot());
        }
    }

    IEnumerator shoot()
    {
        foreach(Transform turret in bulletSpawner)
        {
            shootTurret(turret);
            float shootDelay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(shootDelay);
        }
        isFiring = false;
    }

    private void shootTurret(Transform turret)
    {
        var bullet = Instantiate(bulletPrefab, turret.position, turret.rotation);
        bullet.GetComponent<Rigidbody>().velocity = turret.forward * bulletSpeed;
    }
}
