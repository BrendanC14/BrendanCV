using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListItem : MonoBehaviour, IListItem
{
    public TextMeshProUGUI _itemTMP;
    public TextMeshProUGUI ItemTMP
    {
        get { return _itemTMP; }
    }

    public GameObject GameObject
    {
        get { return gameObject; }
    }
}
