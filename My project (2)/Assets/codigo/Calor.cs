using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Calor : MonoBehaviour
{

    public CambioColor Comparacion;
    public SpriteRenderer imagenPrueba;
    public DagaSeleccionda colorDaga;
    public Text calorOptimo;
    public int entrega;

    // Start is called before the first frame update
    void Start()
    {

        imagenPrueba.color=new Color(colorDaga.red,colorDaga.green,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Comparacion.r > colorDaga.red&&Comparacion.g<colorDaga.green)
        {
            calorOptimo.text="calor optimo: si";
            entrega=1;
        }
        else
        {
            calorOptimo.text="calor optimo: no";
            entrega=2;
        }
    }
}
