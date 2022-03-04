using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveNegativeDisplay : MonoBehaviour
{
    public ListPanel PositiveList;
    public ListPanel NegativeList;
    public GameObject PositiveListItemPrefab;
    public GameObject NegativeListItemPrefab;

    public void Inititialize(ScoutReport report)
    {
        PositiveList.Banner.ChangeBackgroundColour(ColourUtil.Instance.PositiveColour);
        PositiveList.Banner.TitleTMP.text = "Positives";
        PositiveList.Banner.TitleTMP.color = ColourUtil.Instance.DefaultHighlightColour;
        foreach (string positiveReport in report.PositiveValues)
        {
            GameObject positiveReportGO = Instantiate(PositiveListItemPrefab);
            ListItem item = positiveReportGO.GetComponent<ListItem>();
            item.ItemTMP.text = positiveReport;
            PositiveList.AddListItem(item);
        }
        NegativeList.Banner.ChangeBackgroundColour(ColourUtil.Instance.NegativeColour);
        NegativeList.Banner.TitleTMP.text = "Negatives";
        NegativeList.Banner.TitleTMP.color = ColourUtil.Instance.DefaultHighlightColour;
        foreach (string negativeReport in report.NegativeValues)
        {
            GameObject negativeReportGO = Instantiate(NegativeListItemPrefab);
            ListItem item = negativeReportGO.GetComponent<ListItem>();
            item.ItemTMP.text = negativeReport;
            NegativeList.AddListItem(item);
        }

    }
}
