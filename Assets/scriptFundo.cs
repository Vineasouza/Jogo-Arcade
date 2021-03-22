using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFundo : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 3;
    private float altura;
    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize * 2;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -altura)
        {
            transform.position = new Vector2(0, altura);
        }
    }
}
