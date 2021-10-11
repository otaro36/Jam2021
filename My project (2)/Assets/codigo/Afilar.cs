using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Afilar : MonoBehaviour
{
    public Sprite[] cambiosSpra;
    public DagaSeleccionda filoPrueba;
    public float filo;
    int ca = 0;
    public AudioSource mi_audio;
    public void OnTriggerEnter2D(Collider2D other)
    {
        filoPrueba.filo=filo;
        if (other.CompareTag("lomo"))
        {
            filo-= 1;
        }
        if (other.CompareTag("mango"))
        {
            filo -= 1.5f;
            
        }
        if (other.CompareTag("filo"))
        {
            mi_audio.Play();
            other.GetComponentInParent<SpriteRenderer>().sprite = cambiosSpra[0];
            filo++;
        }
    }
}
