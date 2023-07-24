using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMuerte : MonoBehaviour
{
    public bool dead = false;
    public GameObject Canvas;
    public GameObject jugador;
    public Vector3 Spawn;

    public void Start()
    {
        Canvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (dead)
        {
            Canvas.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
       
    }
    public void Reintentar()
    {
        Time.timeScale = 1f;
        dead = false;
        jugador.transform.position = Spawn;
        Canvas.gameObject.SetActive(false);
    }
    public void SalirAlMenu(string Menu)
    {
        Time.timeScale = 1f;
        dead = false;
        SceneManager.LoadScene(Menu);
    }
}
