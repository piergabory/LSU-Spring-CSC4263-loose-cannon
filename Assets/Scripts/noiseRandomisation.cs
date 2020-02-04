using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noiseRandomisation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.pitch = Random.Range(0.8f, 1.1f);
        source.volume = Random.Range(0.8f, 1f);   
    }
}
