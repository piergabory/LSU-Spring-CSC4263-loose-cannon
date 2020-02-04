using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject[] pins;
    
    // Update is called once per frame
    void Update()
    {
        bool strike = true;
        foreach (GameObject pin in pins) {
            strike &= pin.GetComponent<PinBehaviour>().hasFallen;
        }

        if (strike) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
