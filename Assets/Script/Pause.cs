using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool aberto = false;

    public GameObject pause;

    void Update()
    {
        //if (aberto == true)
        //{
        //    Cursor.lockState = CursorLockMode.None;
        //}
        ////else
        ////    abrir();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (aberto == true)
            {
                pause.SetActive(false);
                aberto = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
                abrir();
        }
    }
    public void abrir()
    {
        Cursor.lockState = CursorLockMode.None;
        pause.SetActive(true);
        aberto = true;
    }
}

