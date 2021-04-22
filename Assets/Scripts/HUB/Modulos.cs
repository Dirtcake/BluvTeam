using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modulos : MonoBehaviour
{
    public List<GameObject> modulo;
    private int ultimaMemoria;

    public void AumentarHUB()// quando tiver um sistema para guardar informacoes colocar aqui o int de ultima memoria ou nivel
    {
        modulo[ultimaMemoria].SetActive(true);
        //TODO quando pegar uma fita ativa essa funcao ultimaMemoria++;

    }
}
