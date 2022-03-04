using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutReportDisplay : AbstractPlayerDisplay
{
    public BannerWithNationalColours Banner;
    public PositionAbilityDisplay PositionAbility;
    public EmploymentDetailDisplay EmploymentDetailDisplay;
    public PositiveNegativeDisplay PositiveNegativeDisplay;
    public StandardBanner ScoutOpinionBanner;

    public void Initialize(ScoutReport report)
    {
        base.Initialize(report.Player, "Scout Report");
        Banner.Initialize(
            "Scout Report",
            report.DateOfReport.ToShortDateString(),
            ColourUtil.Instance.GetColourForNationality(report.Player.Nationality),
            ColourUtil.Instance.GetHighlightColourForNationality(report.Player.Nationality));
        PositionAbility.Initialize(report);
        EmploymentDetailDisplay.Initialize(report);
        PositiveNegativeDisplay.Inititialize(report);
        if (typekey.Interest.PositiveInterest(report.Interest))
        {
            ScoutOpinionBanner.ChangeBackgroundColour(ColourUtil.Instance.PositiveColour);
        }
        else
        {
            ScoutOpinionBanner.ChangeBackgroundColour(ColourUtil.Instance.NegativeColour);
        }
        ScoutOpinionBanner.TitleTMP.color = ColourUtil.Instance.DefaultHighlightColour;
        ScoutOpinionBanner.TitleTMP.text = report.ScoutsOpinion;
    }
}
