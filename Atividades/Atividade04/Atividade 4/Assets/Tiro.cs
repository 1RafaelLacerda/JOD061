using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    [Header("Atributos_Munição")]
    public float bulletSpeed;
     public float timeDestroyShoot;
    void Awake()
    {
        timeDestroyShoot = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        bulletSpeed = 150 * Time.deltaTime;
        transform.Translate(0, 0, bulletSpeed);
        DestroyProjectile();
    }
    public void DestroyProjectile() => Destroy(gameObject, timeDestroyShoot);
}
