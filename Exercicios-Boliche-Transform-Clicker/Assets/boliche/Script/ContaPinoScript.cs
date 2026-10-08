using TMPro;
using UnityEngine;

public class ContaPinoScript : MonoBehaviour
{
    int pontos = 0;
    public TMP_Text pontoUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void OnTriggerExit(Collider other)
    {
        pontos++;
        pontoUI.text = pontos.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Pontos: " + pontos);
    }
}
