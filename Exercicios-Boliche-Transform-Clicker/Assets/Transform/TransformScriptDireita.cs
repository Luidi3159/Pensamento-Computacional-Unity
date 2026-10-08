using UnityEngine;

public class TransformScriptDireita : MonoBehaviour
{
    [SerializeField] private Transform modelo;
    [SerializeField] private float distancia = 1f;
    public void MoverParaDireita()
    {
        modelo.Translate(Vector3.right * distancia);
    }
}
