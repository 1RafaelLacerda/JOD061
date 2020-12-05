using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visaodocara : MonoBehaviour
{
    [Header("GameObjects")]
    private GameObject arma;
    public GameObject bullet;
    public Transform canoArma;
    [Header("Valores Pistola")]
    public int municao;
    public int pente;
    private float fireHate;
    private float timeToShoot;
    [Header("Audio e Animações")]
    public AudioSource pistolaSFX;
    public AudioSource ReloadWeapon;
    void Awake()
    {
        municao = 1000000;
        pente = 3;
        fireHate = 1.5f;
        timeToShoot = 3;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (municao > 0)
            {
                if (timeToShoot > 0.2)
                {
                    municao--;
                    //pistolaSFX.Play();
                    Instantiate(bullet, canoArma.position, canoArma.rotation);
                    timeToShoot = 0;
                }
            }
        }
        timeToShoot += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (municao == 0 && pente > 0)
            {
                pente -= 1;
                municao = 10;
            }
        }
    }

}
