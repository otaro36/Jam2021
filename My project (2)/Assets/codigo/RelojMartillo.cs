using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelojMartillo : MonoBehaviour
{

    public float tiempo;
    public Text tiempotxt;
    public Text mensaje;
    public CogerYsoltar scriptCogerySoltar;
    public GameObject panel;
    public Forjado resistencia;
    public GameObject lis;
    void Update()
    {
        CalcularTiempo();
        if (tiempo<0)
        {
            tiempotxt.text = 0 + ":" + 0;
            scriptCogerySoltar.enabled=false;
           // resistencia.Forjado.enabled = false;
            lis.SetActive(false);
            panel.SetActive(true);
            mensaje.text="Tu Daga tiene una resistencia de "+ resistencia.resitencia;
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
