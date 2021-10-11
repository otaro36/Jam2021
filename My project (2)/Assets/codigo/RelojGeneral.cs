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
            mensaje.text="tu indice de dureza es "+calorScript.dureza;

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
