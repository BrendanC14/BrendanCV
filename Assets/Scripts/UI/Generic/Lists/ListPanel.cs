using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPanel : MonoBehaviour
{
    public Transform ItemParent;
    public StandardBanner Banner;

    public void AddListItem(IListItem item)
    {
        item.GameObject.transform.SetParent(ItemParent, false);
    }
}
