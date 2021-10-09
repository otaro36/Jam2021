using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EscenaManager : MonoBehaviour
{
   
    public void CambiarNivel(int nivel)
    {
        if (nivel == 0)
        {
            SceneManager.LoadScene("Inicio");
        }
        else if (nivel == 1)
        {
            StartCoroutine("MenuSeleccion");
        }
        else
        {
            SceneManager.LoadScene("Game_" + nivel);
        }
    }

    IEnumerator PausaEscena()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("MenuSeleccion");
    }
}
