using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    private float largura;
    private float altura;
    public float vel = 1;
    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
        rbd.velocity = new Vector2(0, -vel);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag!= "Player")
        {
            GameObject gamePlacar = GameObject.Find("controlePlacar");
            scriptPlacar script = gamePlacar.GetComponent<scriptPlacar>();
            script.incrementar(1);
        }
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < - altura) {
            Destroy(this.gameObject);
        }    
    }
}
