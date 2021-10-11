using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMartillo : MonoBehaviour
{
    public GameObject martillo;
    public Transform golpe;
    public Transform salida;
    public Vector3 moverHacia;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        moverHacia=golpe.position;
    }

    // Update is called once per frame
    void Update()
    {
               martillo.transform.position=Vector3.MoveTowards(martillo.transform.position,moverHacia,speed*Time.deltaTime);
        if(martillo.transform.position==golpe.position)
        {
                moverHacia=salida.position;
        }
        if(martillo.transform.position==salida.position)
        {
                moverHacia=golpe.position;
        }
    }
}
