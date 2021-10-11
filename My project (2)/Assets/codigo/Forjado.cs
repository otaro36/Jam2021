using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forjado : MonoBehaviour
{
        public int martillazos;
        public Text cantidadMartillazos;
        public int golpesrecibidos;
        public float resitencia;
        public DagaSeleccionda resistensiaScrit;

        public AudioSource audioMartillo;

    // Start is called before the first frame update
    void Start()
    {
        martillazos=5;
    }

    // Update is called once per frame
    void Update()
    {
        resistensiaScrit.resistencia=resitencia;
        cantidadMartillazos.text=martillazos.ToString();

        if (martillazos==golpesrecibidos)
        {
            StartCoroutine("Esperar");         
        }
        if (martillazos<golpesrecibidos)
        {
            resitencia-=0.05f;
        }
    }
        private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="Martillo")
        {
            golpesrecibidos++;
            audioMartillo.Play(0);
        }
    }
    IEnumerator Esperar()
    {
        resitencia+=0.05f;
        cantidadMartillazos.text="retira la barra";
        yield return new WaitForSecondsRealtime(3);
        martillazos=Random.Range(1,6);  
        golpesrecibidos=0;     
    }
}
