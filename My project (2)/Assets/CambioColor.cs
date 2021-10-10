using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public Color color;
    public float r;
    public float g;
    public float b;


    void Update()
    {

    }
    public void Example()
    {
        r += 0.1f;
        g += 0f;
        b = 0f;
        color = new Color(r, g, b);
        print(color.gamma);
    }

}
