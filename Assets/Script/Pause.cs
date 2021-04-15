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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (aberto == true)
            {
                pause.SetActive(false);
                aberto = false;
            }
            else
                abrir();
        }
    }
    public void abrir()
    {
        pause.SetActive(true);
        aberto = true;
    }
}

