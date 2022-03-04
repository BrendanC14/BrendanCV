using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StandardBanner : MonoBehaviour
{
    public Image Image;
    public TextMeshProUGUI TitleTMP;

    public virtual void Initialize(string title)
    {
        TitleTMP.text = title;
    }

    public void ChangeBackgroundColour(Color newColor)
    {
        Image.color = newColor;
    }
}
