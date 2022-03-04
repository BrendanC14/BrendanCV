using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class TMPExtensions
{
    public static void AsPositive(this TextMeshProUGUI tmp)
    {
        tmp.color = ColourUtil.Instance.PositiveColour;
    }

    public static void AsNegative(this TextMeshProUGUI tmp)
    {
        tmp.color = ColourUtil.Instance.NegativeColour;
    }
}
