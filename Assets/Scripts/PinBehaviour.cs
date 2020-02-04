using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehaviour : MonoBehaviour
{
    public Material initialMaterial; 
    public Material fallenMaterial;
    public MeshRenderer renderer;

    bool _hasFallen = false;

    public bool hasFallen {
        get => _hasFallen;
    }

    // Start is called before the first frame update
    void Start()
    {
        renderer.sharedMaterial = initialMaterial;
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.name == "Ground") {
            renderer.sharedMaterial = fallenMaterial;
            _hasFallen = true;
        }
        AudioSource source = GetComponent<AudioSource>();
        source.pitch = Random.Range(0.3f, 1f);
        source.volume = Random.Range(0.8f, 1f);
        source.Play();
    }
}
