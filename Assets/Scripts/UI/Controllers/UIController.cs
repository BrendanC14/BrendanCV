using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public int ScoutReportPosition;
    public int ProfilePosition;
    public int JobHistoryPosition;

    public GameObject ScoutReportPrefab;
    public GameObject ProfilePrefab;
    public GameObject JobHistoryPrefab;
    public DefaultButton NextScreenButton;
    public DefaultButton PreviousScreenButton;

    private int _currentScreenPosition;
    public int CurrentScreenPosition
    {
        get { return _currentScreenPosition; }
        set
        {
            _currentScreenPosition = value;
            PreviousScreenButton.gameObject.SetActive(_currentScreenPosition > 0);
            NextScreenButton.gameObject.SetActive(_currentScreenPosition < OrderedScreens.Count - 1);
            ShowScreen(_currentScreenPosition);
        }
    }
    private List<string> OrderedScreens = new List<string>();
    GameObject CurrentScreen;

    Player Brendan = new Player("Brendan", "Cutler", new System.DateTime(1992, 09, 18), "English");

    // Start is called before the first frame update
    void Start()
    {
        Brendan.HirePlayer("Agile Developer", "LV=");
        OrderScreens();
        CurrentScreenPosition = 0;
        PreviousScreenButton.onClick(() => CurrentScreenPosition--);
        NextScreenButton.onClick(() => CurrentScreenPosition++);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Takes the values provided from Unity Studio and sorts them from smallest to largest.
    /// Each int is then assigned to the string name of the appropriate screen.
    /// The string is then added to the OrderedScreens list.
    /// This gives the ability to change the order of the screens from the Unity Studio without rewriting code.
    /// </summary>
    private void OrderScreens()
    {
        Dictionary<int, string> ScreenByPositionMap = new Dictionary<int, string>()
        {
            { ScoutReportPosition, "Scout Report" },
            { ProfilePosition, "Profile" },
            { JobHistoryPosition, "Job History" }
        };
        List<int> PositionsOrdered = new List<int>()
        {
            ScoutReportPosition,
            ProfilePosition,
            JobHistoryPosition
        };
        PositionsOrdered.Sort();
        foreach (int position in PositionsOrdered)
        {
            OrderedScreens.Add(ScreenByPositionMap[position]);
        }
    }

    /// <summary>
    /// This method will destroy the GameObject for the current screen on show. 
    /// </summary>
    private void HideCurrentScreen()
    {
        if (CurrentScreen != null)
        {
            Destroy(CurrentScreen);
        }
    }

    /// <summary>
    /// This method will Display the appropriate screen from OrderedScreens, based on the position provided.
    /// If OrderedScreens does not have a value in the position provided, the ScoutReport will be shown as a default.
    /// It starts off by hiding the current screen.
    /// It will also update the Texts of the Previous/Next buttons based on what is next in the list.
    /// </summary>
    /// <param name="screenPosition">Which screen to show</param>
    private void ShowScreen(int screenPosition)
    {
        HideCurrentScreen();
        string screenName = (OrderedScreens.Count > 0 && screenPosition >= 0 && screenPosition < OrderedScreens.Count)
            ? OrderedScreens[screenPosition]
            : "";

        switch (screenName)
        {
            case "Job History": ShowJobHistory(); break;
            case "Profile": ShowProfile(); break;
            default: ShowScoutReport(); break;
        }
        if (screenPosition > 0)
        {
            PreviousScreenButton.Text.text = OrderedScreens[screenPosition - 1];
        }
        if (screenPosition < OrderedScreens.Count -1)
        {
            NextScreenButton.Text.text = OrderedScreens[screenPosition + 1];
        }

    }

    /// <summary>
    /// The method will instantiate the ScoutReport GameObject using the prefab defined from the UnityStudio.
    /// The ScoutReportDisplay component will be initialized using the ScoutReport belonging to Player Brendan.
    /// If Brendan has not been scouted, ScoutBrendan() will be called beforehand.
    /// </summary>
    public void ShowScoutReport()
    {
        if (!Brendan.Scouted)
        {
            ScoutBrendan();
        }
    GameObject reportGO = Instantiate(ScoutReportPrefab);
        reportGO.transform.SetParent(transform, false);
        ScoutReportDisplay display = reportGO.GetComponent<ScoutReportDisplay>();
        display.Initialize(Brendan.ScoutReport);
        CurrentScreen = reportGO;
    }

    /// <summary>
    /// This method will generate a hardcoded ScoutReport object for Brendan.
    /// </summary>
    public void ScoutBrendan()
    {
        ScoutReport report = new ScoutReport(Brendan);
        report.Ability = 3;
        report.Potential = 5;
        report.Availibility = "3 months notice period";
        report.Interest = typekey.Interest.EXTREMELY_INTERESTED;
        report.EstimatedCost = 0.00m;
        report.EstimatedWageMin = 45.0m;
        report.EstimatedWageMax = 50.0m;
        report.AddPositiveValues(new List<string>()
        {
            "Confident C# Developer",
            "6 years experience with Scaled Agile Framework",
            "4 years experience with Unity",
            "Enjoys working in a team of Developers, Analysts & QA",
            "Extremely passionate about his work"
        });
        report.AddNegativeValue("No professional game development experience");
        report.ScoutsOpinion = "Your scout thinks Brendan would be extremely interested in joining the team.";
        Brendan.ScoutReport = report;
    }

    /// <summary>
    /// The method will instantiate the JobHistory GameObject using the prefab defined from the UnityStudio.
    /// The JobHistoryDisplay component will be initialized using the JobHistory List belonging to Player Brendan.
    /// If Brendan does not have any JobHistories, AddBrendansJobHistory() will be called beforehand.
    /// </summary>
    private void ShowJobHistory()
    {
        if (Brendan.JobHistory.Count == 0)
        {
            AddBrendansJobHistory();
        }
        GameObject historyGO = Instantiate(JobHistoryPrefab);
        historyGO.transform.SetParent(transform, false);
        JobHistoryDisplay display = historyGO.GetComponent<JobHistoryDisplay>();
        display.Initialize(Brendan);
        CurrentScreen = historyGO;
    }

    /// <summary>
    /// This method will generate hardcoded JobHistories for Brendan.
    /// </summary>
    private void AddBrendansJobHistory()
    {
        Brendan.AddJobHistory(new JobHistory(2022, "LV=", "Agile Developer"));
        Brendan.AddJobHistory(new JobHistory(2021, "LV=", "Junior Agile Developer"));
        for (int i = 2020; i > 2018; i--)
        {
            Brendan.AddJobHistory(new JobHistory(i, "LV=", "Agile Product Owner"));
        }
        for (int i = 2018; i > 2016; i--)
        {
            Brendan.AddJobHistory(new JobHistory(i, "LV=", "Agile Subject Matter Expert"));
        }
        for (int i = 2016; i > 2010; i--)
        {
            Brendan.AddJobHistory(new JobHistory(i, "LV=", "Customer Service Representative"));
        }
        Brendan.AddJobHistory(new JobHistory(2010, "Co-Operative Food", "Customer Representative"));
    }

    /// <summary>
    /// The method will instantiate the Profile GameObject using the prefab defined from the UnityStudio.
    /// The ProfileDisplay component will be initialized using the Bio belonging to Player Brendan.
    /// If Brendan does not have a Bio, AddBrendansBio() will be called beforehand.
    /// </summary>
    private void ShowProfile()
    {
        if (Brendan.Bio == null)
        {
            AddBrendansBio();
        }
        GameObject profileGO = Instantiate(ProfilePrefab);
        profileGO.transform.SetParent(transform, false);
        ProfileDisplay display = profileGO.GetComponent<ProfileDisplay>();
        display.Initialize(Brendan);
        CurrentScreen = profileGO;
    }

    /// <summary>
    /// This method will generate hardcoded Bio for Brendan.
    /// </summary>
    private void AddBrendansBio()
    {
        Brendan.Bio = "\n" +
            "Brendan was born in Poole on the 18th September 1992. Brendan is currently living in Bournemouth working as an Agile Developer for LV= Insurance.\n" +
            "Brendan's first job was working for a Co-Op whilst he finished school. " +
            "In October 2010 Brendan started working in the Call Centre for LV= Car Insurance.\n\n" +
            "In June 2016 Brendan joined an Agile project replacing the admin systems throughout the entire General Insurance company. " +
            "It was here that he began working with Developers, Testers, Scrum Masters and Business Analyst writing Acceptance Crtieria with a User-first mindset.\n" +
            "After joining the project, Brendan found a love for code and used his insight to teach himself Java to build small, helpful apps at home.\n\n" +
            "In 2018 Brendan was promoted to Product Owner where he managed Features from the design phase through to implementation, working even closer with his Agile team." +
            "He would also be responsible for presenting his Features at the PI Planning sessions, as well as contributing to an overall 'Definition of Done'.\n" +
            "Brendan's home projects had also moved up to C# and Unity, where he bagan making small games for his two children.\n\n" +
            "It was in 2020 that Brendan's true passion becamse his job, and he made the switch from Product Owner to Junior Developer, where he began building Stories using the Gosu programming language.\n" +
            "Only a year had passed, and Brendan was promoted to mid-range Developer in 2021 where he started to build Features as well as Stories. " +
            "His experience on both sides of the Feature, coupled with his determination to learn, has made him a fundamental part of his team.";
    }
}
