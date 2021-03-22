using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptControle : MonoBehaviour
{
    public GameObject inimigo;
    private float altura;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("respawn", 0, 1);
        altura = Camera.main.orthographicSize;
    }

    void respawn()
    {
        float limiteHorizontal = Camera.main.orthographicSize * Camera.main.aspect;
        Vector2 respawPosition = new Vector2(Random.Range(-limiteHorizontal, limiteHorizontal), altura);
        Instantiate(inimigo, respawPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
