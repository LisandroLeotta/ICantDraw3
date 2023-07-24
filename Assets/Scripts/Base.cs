using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Base : MonoBehaviour
{
    public GameObject CanvasMenu;
  

    public void Iniciar (string Nivel1)
    {
        SceneManager.LoadScene(Nivel1);
    }

  

   
    public void CerrarJuego()
    {
        Application.Quit();
    }
}
