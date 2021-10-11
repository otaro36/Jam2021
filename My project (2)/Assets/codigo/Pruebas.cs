using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
  public   int filo;
        public int dureza;
       public int resistencia;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PruebaFilo"))
        {
            other.GetComponent<AudioSource>().Play();
            if (other.GetComponent<caracteristicas>().filo < filo)
            {
                Debug.Log("filo gama");
            }
            if (other.GetComponent<caracteristicas>().filo > filo)
            {
                Debug.Log("filo pierde");
            }
            if (other.GetComponent<caracteristicas>().filo == filo)
            {
                Debug.Log("filo empata");
            }
        }
        if (other.CompareTag("Pruebadureza"))
        {
            other.GetComponent<AudioSource>().Play();
            if (other.GetComponent<caracteristicas>().dureza < dureza)
            {
                Debug.Log("dureza gana");
            }
            if (other.GetComponent<caracteristicas>().dureza > dureza)
            {
                Debug.Log("dureza pierde");
            }
            if (other.GetComponent<caracteristicas>().dureza == dureza)
            {
                Debug.Log("dureza empata");
            }
        }
        if (other.CompareTag("PruebaResistencia"))
        {
            other.GetComponent<AudioSource>().Play();
            if (other.GetComponent<caracteristicas>().resistencia < resistencia)
            {
                Debug.Log("resistencia gana");
            }
            if (other.GetComponent<caracteristicas>().resistencia > resistencia)
            {
                Debug.Log("resistencia pierde");
            }
            if (other.GetComponent<caracteristicas>().resistencia == resistencia)
            {
                Debug.Log("resistencia empata");
            }
        }
    }
}
