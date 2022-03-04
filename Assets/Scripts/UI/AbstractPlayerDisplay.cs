using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractPlayerDisplay : MonoBehaviour
{
    public StandardPlayerHeader PlayerHeader;


    public virtual void Initialize(Player player, string subtitle)
    {
        PlayerHeader.Initialize(player, subtitle);
    }
}
