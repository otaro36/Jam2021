using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    int filo;
        int dureza;
        int resistencia;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PruebaFilo"))
        {
            if (other.GetComponent<caracteristicas>().filo < filo)
            {

            }
            if (other.GetComponent<caracteristicas>().filo > filo)
            {

            }
            if (other.GetComponent<caracteristicas>().filo == filo)
            {

            }
        }
        if (other.CompareTag("Pruebadureza"))
        {
            if (other.GetComponent<caracteristicas>().dureza < dureza)
            {

            }
            if (other.GetComponent<caracteristicas>().dureza > dureza)
            {

            }
            if (other.GetComponent<caracteristicas>().dureza == dureza)
            {

            }
        }
        if (other.CompareTag("PruebaResistencia"))
        {
            if (other.GetComponent<caracteristicas>().resistencia < resistencia)
            {

            }
            if (other.GetComponent<caracteristicas>().resistencia > resistencia)
            {

            }
            if (other.GetComponent<caracteristicas>().resistencia == resistencia)
            {

            }
        }
    }
}
