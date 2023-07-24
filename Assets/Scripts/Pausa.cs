using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject Canvas;
    public static bool JuegoEnPausa = false;

    void Start()
    {
        Canvas.gameObject.SetActive(false);
    }

   
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           if (JuegoEnPausa) 
            {
                Canvas.gameObject.SetActive(false);
                Time.timeScale = 1f;
                JuegoEnPausa = false;
             
            }
            else
            {
                Canvas.gameObject.SetActive(true);
                Time.timeScale = 0f;
                JuegoEnPausa = true;
                
            }
        }
        
    }
    public void continuar()
    {
        Canvas.gameObject.SetActive(false);
        Time.timeScale = 1f;
        JuegoEnPausa = false;

    }

    public void cerrar(string Menu)
    {
        SceneManager.LoadScene(Menu);
        JuegoEnPausa = false;
        Time.timeScale = 1f;
    }

}
