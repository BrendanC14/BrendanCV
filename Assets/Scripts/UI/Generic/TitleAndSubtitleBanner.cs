using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleAndSubtitleBanner : StandardBanner
{

    public TextMeshProUGUI SubtitleTMP;

    public override void Initialize(string title)
    {
        TitleTMP.text = title;
    }

    public virtual void Initialize(string title, string subtitle)
    {
        TitleTMP.text = title;
        SubtitleTMP.text = subtitle;
    }
}
