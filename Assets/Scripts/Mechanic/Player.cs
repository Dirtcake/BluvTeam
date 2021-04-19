using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controlador;
    public float playerVelocity;
    void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        Mover();
    }

    private void Mover()
    {
      
        Vector3 move = Vector3.zero;
        move += Input.GetAxis("Horizontal") * transform.right * playerVelocity;
        move += Input.GetAxis("Vertical") * transform.forward * playerVelocity;
       
        if (Pause.aberto == false) 
            controlador.Move(move * Time.deltaTime);
        
    }
}
