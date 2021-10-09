using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//libreria para manejar las scenas del juego 
public static class llamar_carga 
{
    public static string siguiente_nivel;//almacena el nombre de la scena a llamar
    public static void cargar_nivel(string nombre)// metodo estatico para ser llamado por los otros scripts
    {
        siguiente_nivel = nombre;//guarda el nombre dentro de una variable para ser utilizado por el script de "cargaGobal"
        SceneManager.LoadScene("carga global"/*aca se coloca el nombre que tenga la scena que funcionara como carga global */);//n
        //llama la escana de carga que es global dentro del juego 
    }
}
