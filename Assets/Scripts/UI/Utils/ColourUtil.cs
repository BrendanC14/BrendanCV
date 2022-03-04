using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourUtil
{

    private static ColourUtil _instance;
    public static ColourUtil Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ColourUtil();
            }
            return _instance;
        }
    }

    public Color DefaultColour = new Color(0.41f, 0.14f, 0.56f);
    public Color DefaultHighlightColour = new Color(1f, 1f, 1f);
    public Color PositiveColour = new Color(0.03f, 0.76f, 0f);
    public Color NegativeColour = new Color(1f, 0f, 0f);

    private Dictionary<string, Color> ColourByNationalityMap = new Dictionary<string, Color>()
    {
        { "English", new Color(1f, 1f, 1f) }
    };

    private Dictionary<string, Color> HighlightColourByNationalityMap = new Dictionary<string, Color>()
    {
        { "English", new Color(1f, 0f, 0f) }
    };

    public ColourUtil()
    {

    }

    public Color GetColourForNationality(string nationality)
    {
        return ColourByNationalityMap.ContainsKey(nationality)
            ? ColourByNationalityMap[nationality]
            : DefaultColour;
    }
    public Color GetHighlightColourForNationality(string nationality)
    {
        return HighlightColourByNationalityMap.ContainsKey(nationality)
            ? HighlightColourByNationalityMap[nationality]
            : DefaultHighlightColour;
    }
}
