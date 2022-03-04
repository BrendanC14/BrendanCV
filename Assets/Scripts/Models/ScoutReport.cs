using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoutReport 
{

    private Player _player;
    public Player Player
    {
        get { return _player; }
    }

    private DateTime _dateOfReport;
    public DateTime DateOfReport
    {
        get { return _dateOfReport; }
    }

    private int _ability;
    public int Ability
    {
        get { return _ability; }
        set { _ability = value; }
    }

    private int _potential;
    public int Potential
    {
        get { return _potential; }
        set { _potential = value; }
    }

    private string _availibility = "";
    public string Availibility
    {
        get { return _availibility; }
        set { _availibility = value; }
    }

    private typekey.Interest _interest;
    public typekey.Interest Interest
    {
        get { return _interest; }
        set { _interest = value; }
    }

    private decimal _estimatedCost = 0.00m;
    public decimal EstimatedCost
    {
        get { return _estimatedCost; }
        set { _estimatedCost = value; }
    }
    public bool IsFree
    {
        get { return EstimatedCost == 0.00m; }
    }

    private decimal _estimatedWageMin = 0.00m;
    public decimal EstimatedWageMin
    {
        get { return _estimatedWageMin; }
        set { _estimatedWageMin = value; }
    }

    private decimal _estimatedWageMax = 0.00m;
    public decimal EstimatedWageMax
    {
        get { return _estimatedWageMax; }
        set { _estimatedWageMax = value; }
    }

    private List<string> _positiveValues = new List<string>();
    public List<string> PositiveValues
    {
        get { return _positiveValues; }
    }

    private List<string> _negativeValues = new List<string>();
    public List<string> NegativeValues
    {
        get { return _negativeValues; }
    }

    private string _scoutsOpinion = "";
    public string ScoutsOpinion
    {
        get { return _scoutsOpinion; }
        set { _scoutsOpinion = value; }
    }

    public ScoutReport(Player player)
    {
        _player = player;
        //Hardcoding date to today as no 'in-game' date.
        _dateOfReport = DateTime.Now;
    }

    /// <summary>
    /// Method to add multiple positive values to the PositiveValues list.
    /// Each string is passed to the AddPositiveValue() method.
    /// </summary>
    /// <param name="values">List of string objects for each value</param>
    public void AddPositiveValues(List<string> values)
    {
        foreach (string value in values)
        {
            AddPositiveValue(value);
        }
    }

    /// <summary>
    /// Method to add positive value to the PositiveValues list.
    /// </summary>
    /// <param name="value">string for positive value</param>
    public void AddPositiveValue(string value)
    {
        PositiveValues.Add(value);
    }

    /// <summary>
    /// Method to add multiple negative values to the NegativeValues list.
    /// Each string is passed to the AddNegativeValue() method.
    /// </summary>
    /// <param name="values">List of string objects for each value</param>
    public void AddNegativeValues(List<string> values)
    {
        foreach (string value in values)
        {
            AddNegativeValue(value);
        }
    }

    /// <summary>
    /// Method to add positive value to the NegativeValues list.
    /// </summary>
    /// <param name="value">string for negative value</param>
    public void AddNegativeValue(string value)
    {
        NegativeValues.Add(value);
    }
}
