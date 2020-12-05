using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Player : MonoBehaviour 
{
    
    public float Movespeed = 3.5f;
    public float Turnspeed = 120f;

    
    void Update()
    {

        float vert = Input.GetAxis("Vertical");
        float horz = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.forward * vert * Movespeed * Time.deltaTime);
        this.transform.localRotation *= Quaternion.AngleAxis(horz * Turnspeed * Time.deltaTime, Vector3.up);
    }
}
