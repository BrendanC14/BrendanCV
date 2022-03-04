using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalDetailDisplay : MonoBehaviour
{

    public StandardHeaderAndText AgeHeaderAndText;
    public StandardHeaderAndText PositionHeaderAndText;
    public StandardHeaderAndText TeamHeaderAndText;
    public StandardHeaderAndText WageHeaderAndText;

    public void Initialize(Player player)
    {
        AgeHeaderAndText.Initialize("Age", player.Age.ToString());
        PositionHeaderAndText.Initialize("Position", player.CurrentPosition);
        TeamHeaderAndText.Initialize("Team", player.CurrentEmployer);
        WageHeaderAndText.Initialize("Wage", "");
    }
}
