using TMPro;
using UnityEngine;

public class ToggleLabel : MonoBehaviour
{
    public TMP_Text label;
    public string onText = "Lights Off";
    public string offText = "Lights On";

    public void UpdateLabel(bool isOn)
    {
        label.text = isOn ? onText : offText;
    }
}