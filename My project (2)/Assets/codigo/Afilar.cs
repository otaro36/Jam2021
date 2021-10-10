using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Afilar : MonoBehaviour
{
    public Sprite[] cambiosSpra;
    int ca = 0;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("lomo"))
        {
            other.GetComponentInParent<caracteristicas>().filo-= Random.Range(5, 10);
        }
        if (other.CompareTag("mango"))
        {
            other.GetComponentInParent<caracteristicas>().filo -= Random.Range(10, 15);
            
        }
        if (other.CompareTag("filo"))
        {
            other.GetComponentInParent<SpriteRenderer>().sprite = cambiosSpra[0];
            ca++;
        }
    }
}
