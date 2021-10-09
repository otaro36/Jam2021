using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class touch : MonoBehaviour
{
    public Vector3 posicion;// guarda la pos del toque tactil
    public Camera camara;// se utiliza para transformar la pos del toque a un encuadre real
    public Touch miToque;//guarda la informacion del toque en el tactil 
    public Text texto;//interfaz de usuario para pruebas 
    public Transform mover;// transfor del objeto a mover con la informacion del toque 
    void Start()
    {
        camara = Camera.main; //referencia a la camara del jeugo 
    }

    void Update()
    {
        if (Input.touchCount > 0)// pregunta si se esta tocando la pantalla o no 
        {
            miToque = Input.GetTouch(0);// guarda el toque en una variable para ser usada despues 
            posicion = camara.ScreenToViewportPoint(miToque.position);// la posicion es referenciada con los datos de la camara para dar un punto seguro de movimiento 
            // Debug.Log(posicion);
            //texto.text = ("x" + posicion.x + "y" + posicion.y + "z" + posicion.z);
            mover.position = posicion * 5;// iguala la posicion del objeto a mover con la "posicion" ya referenciada 
        }
    }
}
