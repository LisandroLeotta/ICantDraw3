using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaLateral : MonoBehaviour
{
    private float speed = 4f;
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        speed = speed * -1;
    }
}
