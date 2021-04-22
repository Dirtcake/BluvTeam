using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour, IInteragivel
{
    #region [ Public ]

    public Material highLightMaterial;
    public Material defaultMaterial;
    public Material memoriaMaterial;

    [Space(20)]

    public MeshRenderer mr;

    public VideoClip chiado;
    public VideoClip memoria;

    public GameObject tela;
    public GameObject telaMemoria;

    #endregion

    #region [ Private ]

    private Modulos adicionarEspaco;

    #endregion

    public void Start()
    {
        adicionarEspaco = GetComponent<Modulos>();
    }
    public void DownLight()
    {
        mr.material = defaultMaterial;   
    }

    public void HighLight()
    {      
            mr.material = highLightMaterial;
            PlayVideo(chiado, tela);    
    }

    public void Interaction()
    {
        ScreenInvert();
        PlayVideo(memoria,telaMemoria);
        //TODO animacao aproximar da tv 
    }

    public void PosInteraction()
    {
        adicionarEspaco.AumentarHUB();
        ScreenInvert();
        
    }
    public void ScreenInvert()
    {
        var actualState = tela.activeSelf;

        telaMemoria.SetActive(actualState);
        tela.SetActive(!actualState);
        //TODO mudanca de material em vez de telas realmente
    }
    public void PlayVideo(VideoClip video, GameObject tela)
    {
        tela.GetComponent<VideoPlayer>().clip = video;
        tela.GetComponent<VideoPlayer>().Play();

        if (telaMemoria.GetComponent<VideoPlayer>().isPaused)
            PosInteraction();
    }
}
