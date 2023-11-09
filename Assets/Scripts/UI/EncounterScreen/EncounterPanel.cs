using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EncounterPanel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Location _currentEncounter;

    [SerializeField]
    public Location CurrentEncounter
    {
        get
        {
            return _currentEncounter;
        }
        set
        {
            if (_currentEncounter == null)
            {
                _currentEncounter = value;
                EncounterSet();
            }
            _currentEncounter = value;
        }
    }

    private Replica CurrentReplica;

    [Tooltip("Encounter general ")]
    [SerializeField]
    private TextMeshProUGUI EncounterTitle;

    [Tooltip("Actual person or object of interaction")]
    [SerializeField]
    private TextMeshProUGUI EncounterSubject;

    [Tooltip("Dialogue line of subject")]
    [SerializeField]
    private TextMeshProUGUI EncounterLine;

    [Tooltip("Output for left response")]
    [SerializeField]
    private TextMeshProUGUI LeftResponseLine;

    [Tooltip("Output for right response")]
    [SerializeField]
    private TextMeshProUGUI RightResponseLine;

    private void OnEnable()
    {
        CurrentEncounter = CanvasesKeeperSingleton.CurrentLocation;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void EncounterSet()
    {
        EncounterTitle.text = CurrentEncounter.Name;
        EncounterSubject.text = CurrentEncounter.Name;
        CurrentReplica = CurrentEncounter.StartingReplica;
        EncounterLine.text = CurrentReplica.ReplicaText;
        LeftResponseLine.text = CurrentReplica.LeftAnswerText;
        RightResponseLine.text = CurrentReplica.RightAnswerText;

    }

    public void LeftDecisionChoice()
    {
        CurrentReplica = CurrentReplica.LeftOptionNextReplica;
        UpdatePanelText();
    }

    public void RightDecisionChoice()
    {
        CurrentReplica = CurrentReplica.RightOptionNextReplica;
        UpdatePanelText();
    }

    private void UpdatePanelText()
    {
        EncounterTitle.text = CurrentEncounter.Name;
        EncounterSubject.text = CurrentEncounter.Name;
        EncounterLine.text = CurrentReplica.ReplicaText;
        LeftResponseLine.text = CurrentReplica.LeftAnswerText;
        RightResponseLine.text = CurrentReplica.RightAnswerText;
    }
}
