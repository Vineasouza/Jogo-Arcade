using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    private float largura;
    private float altura;
    public float vel = 10;
    public GameObject tiro;
    private AudioSource somTiro;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        somTiro = GetComponent<AudioSource>();
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        // Capturar as setas do teclado
        // Alterar a velocidade ao gameObject

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x,y) * vel;

        if(this.transform.position.x > largura) {
            this.transform.position = new Vector2(-largura, transform.position.y);
        } else if (this.transform.position.x < -largura) {
            this.transform.position = new Vector2(largura, transform.position.y);
        }

        if(this.transform.position.y > 0) {
           this.transform.position = new Vector2(this.transform.position.x, 0);
        } else if (this.transform.position.y < -altura) {
            this.transform.position = new Vector2(this.transform.position.x, -altura);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            somTiro.Play();
            Vector2 pos = new Vector2(transform.position.x, transform.position.y + 1);
            Instantiate(tiro, pos, Quaternion.identity);
            
        }
    }
}
