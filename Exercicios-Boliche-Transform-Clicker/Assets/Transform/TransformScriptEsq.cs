using UnityEngine;

public class TransformScriptEsq : MonoBehaviour
{
    [SerializeField] private Transform modelo;
    [SerializeField] private float distancia = 1f;
    public void MoverParaEsquerda()
    {
        modelo.Translate(Vector3.left * distancia);
    }

}
