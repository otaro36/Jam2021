using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D m_rig;//1
    private float h;//1
    private float v;//1
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_rig = GetComponent<Rigidbody2D>();//1
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        m_rig.velocity = new Vector2(v * speed, m_rig.velocity.y);//1
        v = Input.GetAxis("Vertical");
        m_rig.velocity = new Vector2(h * speed, m_rig.velocity.x);//1
    }
}
