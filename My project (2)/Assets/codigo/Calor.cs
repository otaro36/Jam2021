using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Calor : MonoBehaviour
{

    public CambioColor Comparacion;
    public SpriteRenderer imagenPrueba;
    public Text calorOptimo;
    public float r;
    public float g;

    // Start is called before the first frame update
    void Start()
    {

        imagenPrueba.color=new Color(r,g,0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Comparacion.r > r&&Comparacion.g<g)
        {
            calorOptimo.text="calor optimo: si";
        }
        else
        {
            calorOptimo.text="calor optimo: no";
        }
    }
}
