using UnityEngine;

public class ColorScriptButton : MonoBehaviour
{
    [SerializeField] private Renderer modelo;

    public void MudarParaVermelho()
    {
        modelo.material.color = Color.red;
    }
}
