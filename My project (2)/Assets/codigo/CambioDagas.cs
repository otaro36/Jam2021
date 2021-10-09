using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioDagas : MonoBehaviour
{
    public DagaSeleccionda daga;
    public Sprite[] dagas;
    public Image selector;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selector.sprite = dagas[i];
        daga.dagaSeleccionada = i;
    }
    public void siguienteDagas()
    {
        i++;
        if (i>2)
        {
            i = 2;
        }
    }
    public void AnteriorDagas()
    {
        i--;
        if (i < 0)
        {
            i = 0;
        }
    }
}
