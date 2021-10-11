using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelojPruebas : MonoBehaviour
{
    public float tiempo;
    public Text tiempotxt;
    public Text mensaje;
    public CogerYsoltar scriptCogerySoltar;
    public GameObject panel;
    public Pruebas resultadoFinal;
    public int calificaion;


    // Start is called before the first frame update
    private void Awake()
    {
       

    }
    void Start()
    {
        //tiempotxt.text = "2:00";
    }

    // Update is called once per frame
    void Update()
    {
        calificaion=(resultadoFinal.resultadoFilo+resultadoFinal.resultadoDureza+resultadoFinal.resultadoRiqueza)/3;
        CalcularTiempo();
        if (tiempo<0)
        {
            tiempotxt.text = 0 + ":" + 0;
            scriptCogerySoltar.enabled=false;
            panel.SetActive(true);
            if(calificaion>=2)
            {
                mensaje.text="Tu Daga es letal "+calificaion;
            }
            else
            {
                 mensaje.text="Tu Daga no es letal "+calificaion;
            }
            

        }
    }
    void CalcularTiempo()
    {
        tiempo -= Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        tiempotxt.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');
    }
}
