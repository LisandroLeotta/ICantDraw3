using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    CanvasMuerte CanvasMuerte;
    
    void Awake()
    {
        CanvasMuerte = GameObject.Find("Personaje/Camara").GetComponent<CanvasMuerte>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        CanvasMuerte.dead = true;
    }
}
