using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmploymentDetailDisplay : MonoBehaviour
{
    public StandardHeaderAndText PositionHeaderAndText;
    public StandardHeaderAndText InterestHeaderAndText;
    public StandardHeaderAndText EstimatedCostHeaderAndText;
    public StandardHeaderAndText EstimatedWageHeaderAndText;

    public void Initialize(ScoutReport report)
    {
        PositionHeaderAndText.Initialize("Availibilty", report.Availibility);
        InterestHeaderAndText.Initialize("Interest", report.Interest.Name);
        if (typekey.Interest.PositiveInterest(report.Interest))
        {
            InterestHeaderAndText.ValueTMP.AsPositive();
        }
        else
        {
            InterestHeaderAndText.ValueTMP.AsNegative();
        }
        if (report.IsFree)
        {
            EstimatedCostHeaderAndText.Initialize("Estimated Cost", "Free");
            EstimatedCostHeaderAndText.ValueTMP.AsPositive();
        }
        else
        {
            EstimatedCostHeaderAndText.Initialize("Estimated Cost", report.EstimatedCost.ToString());
            EstimatedCostHeaderAndText.ValueTMP.AsNegative();
        }
        EstimatedWageHeaderAndText.Initialize("Estimated Wage", "£" + report.EstimatedWageMin.ToString("00") + "k - £" + report.EstimatedWageMax.ToString("00") + "k");
    }
}
