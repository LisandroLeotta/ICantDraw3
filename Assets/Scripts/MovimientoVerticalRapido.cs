using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoVerticalRapido : MonoBehaviour
{
    private float speed = 6f;
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        speed = speed * -1;
    }
}
