using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player
{
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
    }

    private string _surname;
    public string Surname
    {
        get { return _surname; }
    }

    public string Name
    {
        get { return FirstName + " " + Surname; }
    }

    private DateTime _dateOfBirth;
    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
    }

    public int Age
    {
        get
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateOfBirth.Date.AddYears(age) > DateTime.Now) { age--; }
            return age;
        }
    }

    private string _nationality;
    public string Nationality
    {
        get { return _nationality; }
    }

    private string _currentPosition;
    public string CurrentPosition
    {
        get { return _currentPosition; }
    }

    private string _currentEmployer;
    public string CurrentEmployer
    {
        get { return _currentEmployer; }
    }
    public bool IsEmployed
    {
        get { return _currentEmployer != null; }
    }

    private ScoutReport _scoutReport;
    public ScoutReport ScoutReport
    {
        get { return _scoutReport; }
        set { _scoutReport = value; }
    }
    public bool Scouted
    {
        get { return _scoutReport != null; }
    }

    private List<JobHistory> _jobHistory = new List<JobHistory>();
    public List<JobHistory> JobHistory
    {
        get { return _jobHistory; }
    }

    private string _bio;
    public string Bio
    {
        get { return _bio; }
        set { _bio = value; }
    }

    public Player(string firstName, string surname, DateTime dob, string nationality)
    {
        _firstName = firstName;
        _surname = surname;
        _nationality = nationality;
        _dateOfBirth = dob;
    }

    /// <summary>
    /// Method to assing the Player its currentPosition & its currentEmployer.
    /// </summary>
    /// <param name="positon">Player's new position</param>
    /// <param name="employer">Player's new employer</param>
    public void HirePlayer(string positon, string employer)
    {
        _currentPosition = positon;
        _currentEmployer = employer;
    }

    /// <summary>
    /// Method to add a JobHistory to the JobHistory List.
    /// </summary>
    /// <param name="jobHistory">JobHistory object to be added</param>
    public void AddJobHistory(JobHistory jobHistory)
    {
        JobHistory.Add(jobHistory);
    }

    /// <summary>
    /// Method to add multiple JobHistorys to the JobHistory List.
    /// Each JobHistory is passed to the AddJobHistory() method.
    /// </summary>
    /// <param name="jobHistories">List of JobHistory objects to add</param>
    public void AddJobHistories(List<JobHistory> jobHistories)
    {
        foreach (JobHistory jobHistory in jobHistories)
        {
            AddJobHistory(jobHistory);
        }
    }
}
