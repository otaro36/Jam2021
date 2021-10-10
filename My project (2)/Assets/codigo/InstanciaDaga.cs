using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciaDaga : MonoBehaviour
{
    public DagaSeleccionda daga;
    public Sprite[] dagas;
    public Image selector;
    void Update()
    {
        selector.sprite = dagas[daga.dagaSeleccionada];
    }
}
