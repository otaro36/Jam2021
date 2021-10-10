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
    void Start()
    {
        //g = -0.8f;
        color = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Horno")
        {
            StartCoroutine("Calentar");
            if (r==1&&g==1)
            {
                r = 1.1f;
                g = 1.1f;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag== "Horno")
        {
            StartCoroutine("Enfriar");
        }
    }
    IEnumerator Calentar()
    {

        color.color= new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0.1f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0.3f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0.5f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0.7f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 1f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 1f;
        g = 0.1f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 1f;
        g = 0.3f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 1f;
        g = 0.5f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 1f;
        g = 0.7f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 1f;
        g = 1f;
        color.color = new Color(r, g, 0);

    }
    IEnumerator Enfriar()
    {
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        g = 1f;
        r = 1f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        g = 0.7f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        g = 0.5f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        g = 0.3f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        g = 0.0f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0.7f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0.5f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0.3f;
        color.color = new Color(r, g, 0);
        yield return new WaitForSecondsRealtime(2);
        r = 0f;
        color.color = new Color(r, g, 0);
    }
}
