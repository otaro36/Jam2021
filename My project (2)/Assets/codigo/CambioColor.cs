using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public SpriteRenderer color;
    public float r;
    public float g;
    public float red;
    public float green;
    public AudioSource mi_audio;
    void Start()
    {
        //g = -0.8f;
        color = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        color.color = new Color(r, g, 0);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Horno")
        {
            StartCoroutine("Calentar");
        }
        if (other.tag == "Agua")
        {
            mi_audio.Play();
            StartCoroutine("Enfriar");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Agua")
        {
            mi_audio.Pause();
        }
    }
    IEnumerator Calentar()
    {
        incremento();
        yield return new WaitForSecondsRealtime(2* Time.deltaTime);


    }
    IEnumerator Enfriar()
    {
        Decremento();
        yield return new WaitForSecondsRealtime(2* Time.deltaTime);
    }
    public void incremento()
    {
        r += 0.01f;
        if (r > 1)
        {
            g += 0.01f;
            if (g == 1)
            {
                r = 1.1f;
                g = 1.1f;
            }
        }
    }
    public void Decremento()
    {

        if (g > 0)
        {
            g -= 0.01f;
            if (g > 0)
            {
                r -= 0.01f;
            }
        }
        else
        {
            r -= 0.01f;
        }

    }   
}
