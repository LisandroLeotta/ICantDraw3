using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tesoro : MonoBehaviour
{

    public SpriteRenderer SpriteRenderer;
    public Sprite newSprite;
    public Dialogo dialogo;
    public GameObject Monologo1;
    public GameObject monologo2;
    public GameObject monologo3;
    public GameObject monologo4;
    public GameObject ZonaMonologo;
    public bool CambioCara = false;
    public bool Mono1 = false;
    public bool Mono2 = false;
    public bool mono3 = false;
    public bool mono4 = false;
    

    private void Start()
    {
        monologo2.gameObject.SetActive(false);
        monologo3.gameObject.SetActive(false);
        monologo4.gameObject.SetActive(false);
        ZonaMonologo.gameObject.SetActive(false);
    }
    void ChangeSprite()
    {
        SpriteRenderer.sprite = newSprite;
        CambioCara = true;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        dialogo.QuintoDialogo = true;
        ChangeSprite();
    }

    public void Update()
    {
        if(CambioCara == true)
        {
            ZonaMonologo.gameObject.SetActive(true);
            CambioCara = false;
            Mono1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && Mono1 == true)
        {
            Monologo1.gameObject.SetActive(false);
            monologo2.gameObject.SetActive(true);
            Mono1 = false;
            Mono2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && Mono2 == true)
        {
            monologo2.gameObject.SetActive(false);
            monologo3.gameObject.SetActive(true);
            Mono2 = false;
            mono3 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && mono3 == true)
        {
            monologo3.gameObject.SetActive(false);
            monologo4.gameObject.SetActive(true);
            mono3 = false;
            mono4 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && mono4 == true)
        {
            Application.Quit();
        }
    }
}
