using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMusica : MonoBehaviour
{
    private AudioSource som;
     public AudioClip[] musicas = new AudioClip[10];
    // Start is called before the first frame update
    void Start()
    {
        som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!som.isPlaying)
        {
            int mus = Random.Range(0, 9);
            som.PlayOneShot(musicas[mus]);
        }
    }
}
