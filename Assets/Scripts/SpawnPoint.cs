using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    CanvasMuerte spawn;
    private void Awake()
    {
        spawn = GameObject.Find("Personaje/Camara").GetComponent<CanvasMuerte>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        spawn.Spawn = transform.position;
    }
}
