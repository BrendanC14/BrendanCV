using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StandardPlayerHeader : MonoBehaviour
{
    public TwoTonedBackground background;
    public Image Flag;
    public TextMeshProUGUI NameTMP;
    public TextMeshProUGUI SubtitleTMP;

    public void Initialize(Player player)
    {
        Color nationalityColour = ColourUtil.Instance.GetColourForNationality(player.Nationality);
        background.ChangeBackgroundColor(nationalityColour);
        Sprite flagImage = FlagUtil.Instance.GetFlagForNationality(player.Nationality);
        Flag.sprite = flagImage;
        NameTMP.text = player.Name;
        NameTMP.color = ColourUtil.Instance.GetHighlightColourForNationality(player.Nationality);
    }

    public void Initialize(Player player, string subtitleText)
    {
        Color nationalityColour = ColourUtil.Instance.GetColourForNationality(player.Nationality);
        background.ChangeBackgroundColor(nationalityColour);
        Sprite flagImage = FlagUtil.Instance.GetFlagForNationality(player.Nationality);
        Flag.sprite = flagImage;
        NameTMP.text = player.Name;
        NameTMP.color = ColourUtil.Instance.GetHighlightColourForNationality(player.Nationality);
        SubtitleTMP.text = subtitleText;
        SubtitleTMP.color = ColourUtil.Instance.GetHighlightColourForNationality(player.Nationality);
    }
}
