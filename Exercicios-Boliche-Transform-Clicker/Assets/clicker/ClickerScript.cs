using System.Xml.Serialization;
using UnityEngine;
using TMPro;
public class ClickerScript : MonoBehaviour
{
    public int score = 0;
    public int valorBase = 1;
    public TMP_Text uiScore;

    private void Start()
    {
        updateValue();
    }
    public void OnClick()
    {
        score+=valorBase;
        updateValue();
    }
    public void updateValue()
    {
        uiScore.text = score + " $";
    }
}
