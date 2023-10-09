using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EncounterPanel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Location CurrentEncounter;

    [Tooltip("Encounter general ")]
    [SerializeField]
    private TextMeshProUGUI EncounterTitle;

    [Tooltip("Actual person or object of interaction")]
    [SerializeField]
    private TextMeshProUGUI EncounterSubject;

    [Tooltip("Dialogue line of subject")]
    [SerializeField]
    private TextMeshProUGUI EncounterLine;

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
        if (CurrentEncounter != null)
        {

        }
    }
}
