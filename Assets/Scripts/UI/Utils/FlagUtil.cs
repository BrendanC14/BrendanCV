using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagUtil
{

    private static FlagUtil _instance;
    public static FlagUtil Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new FlagUtil();
            }
            return _instance;
        }
    }

    private Dictionary<string, Sprite> SpriteByNameMap = new Dictionary<string, Sprite>();

    public Sprite GetFlagForNationality(string nationality)
    {
        return SpriteByNameMap.ContainsKey(nationality.ToLower())
            ? SpriteByNameMap[nationality.ToLower()]
            : SpriteByNameMap["default"];
    }

    public FlagUtil()
    {
        PopulateSpriteMap();
    }

    private void PopulateSpriteMap()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Flags");
        foreach (Sprite sprite in sprites)
        {
            SpriteByNameMap.Add(sprite.name, sprite);
        }
    }
}
