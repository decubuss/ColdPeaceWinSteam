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

    private List<GameObject> EncounterLines = new List<GameObject>();
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
        foreach (var line in EncounterLines)
        {
            line.SetActive(false);
        }
        EncounterLines.Clear();
        foreach(var loc in Detector.VisibleLocations)
        {

            var isBoo = Detector.VisibleLocations.IndexOf(loc);
            if (isBoo >= EncounterLines.Count)
            {
                var additionalLines = Detector.VisibleLocations.Count - EncounterLines.Count;
                
            }
            var textLine = Instantiate(EncounterLine);
            textLine.transform.SetParent(GridLayoutPanel.transform);
            textLine.GetComponentInChildren<Text>().text = loc.Name;
            EncounterLines.Add(textLine);
        }
    }
}
