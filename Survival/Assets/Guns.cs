using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    public Transform bulletSpawner01;
    public Transform bulletSpawner02;
    public Transform bulletSpawner03;
    public Transform bulletSpawner04;
    public GameObject bulletPrefab;
    public float bulletSpeed = 100;
    public float minDelay = 0.1f;
    public float maxDelay = 0.3f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(shoot(bulletSpawner01));
            StartCoroutine(shoot(bulletSpawner02));
            StartCoroutine(shoot(bulletSpawner03));
            StartCoroutine(shoot(bulletSpawner04));
        }

    }

    IEnumerator shoot(Transform turret)
    {
        float shootDelay = Random.Range(minDelay, maxDelay);
        yield return new WaitForSeconds(shootDelay);
        shootTurret01(turret);
    }

    private void shootTurret01(Transform turret)
    {
        var bullet = Instantiate(bulletPrefab, turret.position, turret.rotation);
        bullet.GetComponent<Rigidbody>().velocity = turret.forward * bulletSpeed;
    }
}
