using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ProfileDisplay : AbstractPlayerDisplay
{
    public BannerWithNationalColours Banner;
    public PersonalDetailDisplay PersonalDetailDisplay;
    public TextMeshProUGUI BioTMP;

    public void Initialize(Player player)
    {
        base.Initialize(player, "Scout Report");
        Banner.Initialize(
            "Scout Report",
            DateTime.Now.ToShortDateString(),
            ColourUtil.Instance.GetColourForNationality(player.Nationality),
            ColourUtil.Instance.GetHighlightColourForNationality(player.Nationality));
        PersonalDetailDisplay.Initialize(player);
        BioTMP.text = player.Bio;
    }
}
