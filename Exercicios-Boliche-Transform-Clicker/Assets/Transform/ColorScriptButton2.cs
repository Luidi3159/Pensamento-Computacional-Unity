using UnityEngine;
public class TrocaCor : MonoBehaviour

{
    [SerializeField] private Renderer modelo;
    [SerializeField] private Color novaCor;
    public void MudarCor()
    {
        modelo.material.color = novaCor;
    }
}