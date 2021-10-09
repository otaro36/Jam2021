using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//libreria de interfaz de usuario 

public class Condicion_derrota : MonoBehaviour
{
    public float solides;//solides de la barra a trabajar
    public float porcentaje_derrota;//el documento de diseño dice q la derrota se cumple cuando la solides llega al 20 % 
    public float calor_fuego;// calor al q va a estar al horno
    public float barra_calor;// maximo calor que va a alcanzar el horno
    public Image imagenBarraFuego;// barra de calor del horno 
    void Start()
    {
        porcentaje_derrota = (solides * 20) / 100;// marca el numero al que va a estar la derrota partiendo de la solides maxima "solides" de la barra y sacando el 20%
        barra_calor = calor_fuego; // copea el maximo del calor deel horno para luego sacar el movimiento de la barra de calor
    }

    // Update is called once per frame
    void Update()
    {
        if (solides <= porcentaje_derrota)// pregunta si la solides ya es igual o menor al porcentaje de derrota para dar por perdida la barra de metal 
        {
            //Debug.Log("perdio");
        }
        imagenBarraFuego.fillAmount = calor_fuego / barra_calor;// sube o baja para demostrar graficamente que tan caliente esta el horno 
    }
}
