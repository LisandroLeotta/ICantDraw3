using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject GloboDeTextoAbuelo;
    public GameObject DialogoAbuelo1;
    public GameObject DialogoAbuelo2;
    public GameObject GloboDeTextoPersonaje;
    public GameObject DialogoPersonaje1;
    public GameObject DialogoPersonaje2;
    public bool PrimerDialogo =false;
    public bool SegundoDialogo =true;
    public bool TercerDialogo =true;
    public bool CuartoDialogo =true;
    public bool QuintoDialogo =true;

    void Start()
    {
        DialogoAbuelo2.gameObject.SetActive(false);
        GloboDeTextoAbuelo.gameObject.SetActive(false);
        DialogoPersonaje2.gameObject.SetActive(false);
        
    }

   
    void Update()
    {
        if(
                Input.GetKeyDown(KeyCode.Return) && PrimerDialogo ==false)
        {
           GloboDeTextoAbuelo.gameObject.SetActive(true);
           PrimerDialogo = true;
           SegundoDialogo = false;
        }
        else if(
                Input.GetKeyDown(KeyCode.Return) && SegundoDialogo ==false)
        {
            DialogoPersonaje1.gameObject.SetActive(false);
            DialogoPersonaje2.gameObject.SetActive(true);
            SegundoDialogo = true;
            TercerDialogo = false;
        }
        else if (
                Input.GetKeyDown(KeyCode.Return) && TercerDialogo ==false)
        {
            DialogoAbuelo1.gameObject.SetActive(false);
            DialogoAbuelo2.gameObject.SetActive(true);
            TercerDialogo = true;
            CuartoDialogo = false;
        }
        else if (
                Input.GetKeyDown(KeyCode.Return) && CuartoDialogo == false)
        {
            Canvas.gameObject.SetActive(false);
            DialogoAbuelo2.gameObject.SetActive(false);
            DialogoPersonaje2.gameObject.SetActive(false);
            CuartoDialogo = true;
            QuintoDialogo = false;
        }
    }
}
