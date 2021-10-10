using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelojGeneral : MonoBehaviour
{
    public float tiempo;
    public Text tiempotxt;
    public Text mensaje;
    public CogerYsoltar scriptCogerySoltar;
    public GameObject panel;
    public Calor calorScript;
    public GameObject entregar;
    public GameObject reintentar;


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
        CalcularTiempo();
        if (tiempo<0)
        {
            tiempotxt.text = 0 + ":" + 0;
            scriptCogerySoltar.enabled=false;
            panel.SetActive(true);
            if (calorScript.entrega==1)
            {
                entregar.SetActive(true);
                mensaje.text="Tu Daga es letal";
            }
            else if(calorScript.entrega==2)
            {
                reintentar.SetActive(true);
                mensaje.text="Tu Daga no es letal";
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
