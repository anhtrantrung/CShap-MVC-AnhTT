using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

// end Bai56
public class Bai30ShootBullet : MonoBehaviour
{
    public Transform gunHead;
    public GameObject bulletFrefab;
    public float bulletSpeed = 5f;

    [SerializeField] List<GameObject> bulletPool;
    void Start()
    {
       InitializePool();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void InitializePool()
    {
        bulletPool = new List<GameObject>();

        for (int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(bulletFrefab);
            obj.SetActive(false);
            bulletPool.Add(obj);
        }
    }

    public GameObject SpawnBullet()
    {
        foreach (GameObject bullet in bulletPool)
        {
            if (!bullet.activeInHierarchy)
            {
               
                return bullet;
            }
        }

        GameObject newBullet = Instantiate(bulletFrefab);
        bulletPool.Add(newBullet);
        return newBullet;
    }   

    public void Fire()
    {
        GameObject bullet = SpawnBullet();
        bullet.SetActive(true);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        bullet.SetActive(true);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.velocity = bullet.transform.forward * bulletSpeed;
    }    
}
