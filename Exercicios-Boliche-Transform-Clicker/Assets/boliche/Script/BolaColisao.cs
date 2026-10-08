using TMPro;
using UnityEngine;

public class BolaColisao : MonoBehaviour
{
    public TMP_Text motivacaoUI;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        motivacaoUI.text = "";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pino"))
        {
            motivacaoUI.text = "BOOYAH!!!";
        }
    }

    private void Update()
    {
        time += Time.deltaTime;
        if(time >= 0.5f && time < 1f)
        {
            motivacaoUI.alpha = 0f;
        }else if(time >= 1f)
        {
            motivacaoUI.alpha= 1f;
            time = 0f;
        }
    }
}
