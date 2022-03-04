using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JobHistoryDisplay : AbstractPlayerDisplay
{
    public BannerWithNationalColours Banner;
    public ListPanel HistoryList;
    public GameObject JobHistoryListItemPrefab;

    public void Initialize(Player player)
    {
        base.Initialize(player, "Job History");
        Banner.Initialize(
            "Job History",
            DateTime.Now.ToShortDateString(),
            ColourUtil.Instance.GetColourForNationality(player.Nationality),
            ColourUtil.Instance.GetHighlightColourForNationality(player.Nationality));

        foreach (JobHistory history in player.JobHistory)
        {
            GameObject historyGO = Instantiate(JobHistoryListItemPrefab);
            JobHistoryListItem item = historyGO.GetComponent<JobHistoryListItem>();
            item.SeasonTMP.text = (history.Season - 1).ToString() + "/" + history.Season.ToString();
            item.TeamTMP.text = history.Team;
            item.PositionTMP.text = history.Position;
            HistoryList.AddListItem(item);
        }
    }
}
