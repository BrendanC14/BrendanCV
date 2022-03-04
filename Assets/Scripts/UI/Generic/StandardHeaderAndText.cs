using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StandardHeaderAndText : MonoBehaviour
{
    public TextMeshProUGUI HeaderTMP;
    public TextMeshProUGUI ValueTMP;

    public StandardHeaderAndText Initialize(string header)
    {
        HeaderTMP.text = header;
        return this;
    }
    public StandardHeaderAndText Initialize(string header, string value)
    {
        HeaderTMP.text = header;
        ValueTMP.text = value;
        return this;
    }
}
