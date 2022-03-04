using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobHistory
{
    private int _season;
    public int Season
    {
        get { return _season; }
    }

    private string _team;
    public string Team
    {
        get { return _team; }
    }

    private string _position;
    public string Position
    {
        get { return _position; }
    }

    public JobHistory(int season, string team, string position)
    {
        _season = season;
        _team = team;
        _position = position;
    }
}
