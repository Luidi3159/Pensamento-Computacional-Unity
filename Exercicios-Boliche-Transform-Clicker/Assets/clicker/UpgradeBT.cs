using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class UpgradeBT : MonoBehaviour
{
    public int upgradeLvl = 0;
    public TMP_Text myBtText;
    public GameObject planetBt;

    private void Start()
    {
        verUpgrade();
    }
    private void verUpgrade()
    {
        Debug.Log("VerUpgrade"+upgradeLvl);
        switch (upgradeLvl)
        {
            case 0:
                updateTxt("Fazer Live contra o meteoro = 20Kwanzas");
                makeUpgrade(20);
                break;
            case 1:
                updateTxt("Organizar eventos beneficentes contra Meteoro  = 100Kwanzas");
                makeUpgrade(100);
                break;
            case 2:
                updateTxt("Comprar o Uranio_137  = 400Kwanzas");
                makeUpgrade(400);
                break;
            case 3:
                updateTxt("Contratar a Nasa e um Exercito = 1000Kwanzas");
                makeUpgrade(1000);
                break;
            case 4:
                updateTxt("Explodira aquela bagaça = 2000Kwanzas");
                makeUpgrade(2000);
                break;
        }
    }
    private void makeUpgrade(int valor)
    {
        if (valor <= planetBt.GetComponent<ClickerScript>().score)
        {
            planetBt.GetComponent<ClickerScript>().score -= valor;
            planetBt.GetComponent<ClickerScript>().valorBase *=2;
            planetBt.GetComponent<ClickerScript>().updateValue();
            upgradeLvl++;
            verUpgrade();
        }
    }
    private void updateTxt(string text)
    {
        myBtText.text = text;
        Debug.Log(text);
    }
    public void OnClick()
    {
        verUpgrade();
    }
}
