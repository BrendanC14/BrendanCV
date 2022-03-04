using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DefaultButton : MonoBehaviour
{
    public Button Button;
    public TextMeshProUGUI Text;

    public void onClick(Action callback)
    {
        Button.onClick.AddListener(() => callback.Invoke());
    }
}
