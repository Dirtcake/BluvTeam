using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public static bool aberto = false;

    public GameObject pause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (aberto == true)
                fechar();
            else
                abrir();
        }
    }
    public void abrir()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pause.SetActive(true);
        aberto = true;
    }
    public void fechar()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pause.SetActive(false);
        aberto = false;       
    }
}

