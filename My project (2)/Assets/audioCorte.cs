using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioCorte : MonoBehaviour
{
    public AudioSource corte;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        corte.Play();
    }
    private void OnTriggerExit2D()
    {
        corte.Pause();
    }
}
