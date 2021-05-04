using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class TV : MonoBehaviour, IInteragivel
{
    public MeshRenderer mr;
    public Material highLightMaterial;
    public Material defaultMaterial;

    [Space(20)]
    public UnityEvent onClick;

    public void DownLight()
    {
        mr.material = defaultMaterial;
    }

    public void HighLight()
    {
        mr.material = highLightMaterial;
    }

    public void Interaction()
    {
        onClick.Invoke();
    }
}
