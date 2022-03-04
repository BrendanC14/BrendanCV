using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PositionAbilityDisplay : MonoBehaviour
{
    public StandardHeaderAndText HeaderAndText;
    public StandardStarAbility CurrentAbility;
    public StandardStarAbility PotentialAbility;
    public TextMeshProUGUI EmployedText;

    public void Initialize(ScoutReport report)
    {
        HeaderAndText.Initialize("Current Position", report.Player.CurrentPosition);
        CurrentAbility.Initialize(true, report.Ability);
        PotentialAbility.Initialize(false, report.Potential);
        EmployedText.text = report.Player.FirstName + (report.Player.IsEmployed
            ? " is currently employed by " + report.Player.CurrentEmployer
            : " is currently unemployed.");
    }
}
