using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JobHistoryListItem : MonoBehaviour, IListItem
{
    public TextMeshProUGUI SeasonTMP;
    public TextMeshProUGUI TeamTMP;
    public TextMeshProUGUI PositionTMP;

    public GameObject GameObject
    {
        get { return gameObject; }
    }
}
