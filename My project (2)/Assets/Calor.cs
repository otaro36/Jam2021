using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Calor : MonoBehaviour
{
    public SpriteRenderer color;
    public CambioColor Comparacion;
    public 
    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        color.color = new Color(0.7f, 0, 0);
        if (color==Comparacion.color)
        {
            print("si");
        }
    }
}
