using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleEncountersDisplay : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> EncounterList;

    [SerializeField]
    public GameObject EncounterLine;
    // Start is called before the first frame update
    void Start()
    {
        EncounterDetector.OnEncounterListUpdated += UpdateEncountersList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateEncountersList()
    {

    }
}
