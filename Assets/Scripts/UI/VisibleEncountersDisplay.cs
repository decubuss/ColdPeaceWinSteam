using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleEncountersDisplay : MonoBehaviour
{
    [SerializeField]
    private EncounterDetector Detector;

    [SerializeField]
    private GameObject EncounterLine;

    [SerializeField]
    private GameObject GridLayoutPanel;
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
        foreach(var loc in Detector.VisibleLocations)
        {
            var textLine = Instantiate(EncounterLine);
            textLine.transform.SetParent(GridLayoutPanel.transform);
            textLine.GetComponentInChildren<Text>().text = loc.Name;
            var list = new List<GameObject>();
        }
    }
}
