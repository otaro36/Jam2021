using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//libreria para manejar las scenas del juego 

public class cargaGlobal : MonoBehaviour
{
           //////IMPORTANTE//////
    //este scrit debe estar dentro de la scena de carga global para su correcto funcionamiento 
    private void Start()
    {
        string leveltoload = llamar_carga.siguiente_nivel;//pregunta cual es la scena que se tiene que cargar 
        StartCoroutine(this.Maketheload(leveltoload));//inicia la rutina para cargar la escena 
    }
    IEnumerator Maketheload(string level)
    {
        yield return new WaitForSeconds(1f);//agrega un segundo a la iniciacion del siguiente nivel 
        AsyncOperation operation= SceneManager.LoadSceneAsync(level);// carga la esena paralelamente para que al ser llamada este lista 
        while (operation.isDone == false)// mientras la operacion sea falsa retorna null
        {
            yield return null;
        }
    }

}
