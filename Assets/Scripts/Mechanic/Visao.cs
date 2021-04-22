using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    IInteragivel interacao;
    private Ray ray;
    private RaycastHit hit;

    private float range = 2;

    public GameObject interactionHint;

    
    private void Start()
    {
        transform.localRotation = Quaternion.Euler(Vector3.zero);
    }

    private void Update()
    {
        PlayerVision();
        RayCast();
    }

    private void PlayerVision()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void RayCast()
    {

        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.yellow); // Usado apenas para ver a direção que o jogador está olhando na Aba Scene

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (interacao != null)
        {
            interacao.DownLight();
            interactionHint.SetActive(false);
        }

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range))
        {
            interacao = hit.transform.GetComponent<IInteragivel>();
            if (interacao != null)
            {
                interacao.HighLight();
                interactionHint.SetActive(true);

                if (Input.GetMouseButtonDown(0) )
                    interacao.Interaction();
            }
        }

    }
}
