using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    public DagaSeleccionda valorePrueba;
    public float filo;
    public float dureza;
    public float resistencia;
    public int resultadoFilo;
    public int resultadoDureza;
    public int resultadoRiqueza;


    void Start()
    {
        filo=valorePrueba.filo;
        dureza=valorePrueba.dureza;
        resistencia=valorePrueba.resistencia;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PruebaFilo"))
        {
            if (other.GetComponent<caracteristicas>().filo < filo)
            {
                Debug.Log("filo gana");
                resultadoFilo=1;
            }
            if (other.GetComponent<caracteristicas>().filo > filo)
            {
                Debug.Log("filo pierde");
                resultadoFilo=-1;
            }
            if (other.GetComponent<caracteristicas>().filo == filo)
            {
                Debug.Log("filo empata");
                resultadoFilo=0;
            }
        }
        if (other.CompareTag("Pruebadureza"))//viene desde el script e calor 
        {
            if (other.GetComponent<caracteristicas>().dureza < dureza)
            {
                Debug.Log("dureza gana");
                resultadoDureza=1;
            }
            if (other.GetComponent<caracteristicas>().dureza > dureza)
            {
                Debug.Log("dureza pierde");
                resultadoDureza=-1;
            }
            if (other.GetComponent<caracteristicas>().dureza == dureza)
            {
                Debug.Log("dureza empata");
                resultadoDureza=0;
            }
        }
        if (other.CompareTag("PruebaResistencia"))
        {
            if (other.GetComponent<caracteristicas>().resistencia < resistencia)
            {
                Debug.Log("resistencia gana");
                resultadoRiqueza=1;
            }
            if (other.GetComponent<caracteristicas>().resistencia > resistencia)
            {
                Debug.Log("resistencia pierde");
                resultadoRiqueza=-1;
            }
            if (other.GetComponent<caracteristicas>().resistencia == resistencia)
            {
                Debug.Log("resistencia empata");
                resultadoRiqueza=0;
            }
        }
    }
}
