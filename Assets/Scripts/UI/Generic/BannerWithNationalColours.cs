using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerWithNationalColours : TitleAndSubtitleBanner
{
    public void Initialize(string title, Color backgroundColor, Color textColour)
    {
        base.Initialize(title);
        if (backgroundColor != null)
        {
            Image.color = backgroundColor;
        }
        if (textColour != null)
        {
            TitleTMP.color = textColour;
        }
    }

    public void Initialize(string title, string subtitle, Color backgroundColor, Color textColour)
    {
        base.Initialize(title, subtitle);
        if (backgroundColor != null)
        {
            Image.color = backgroundColor;
        }
        if (textColour != null)
        {
            TitleTMP.color = textColour;
        }
    }
}
