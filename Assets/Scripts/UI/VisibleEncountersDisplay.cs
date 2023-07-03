using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class VisibleEncountersDisplay : MonoBehaviour
{
    [SerializeField]
    private EncounterDetector Detector;

    [SerializeField]
    private GameObject EncounterButton;

    [SerializeField]
    private GameObject GridLayoutPanel;

    private List<GameObject> DisplayedLocations = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        EncounterDetector.OnEncounterListUpdated += UpdateEncountersListAlt;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateEncountersList()
    {
        foreach (var line in DisplayedLocations)
        {
            line.SetActive(false);
        }
        DisplayedLocations.Clear();
        foreach(var loc in Detector.VisibleLocations)
        {

            var isBoo = Detector.VisibleLocations.IndexOf(loc);
            if (isBoo >= DisplayedLocations.Count)
            {
                var additionalLines = Detector.VisibleLocations.Count - DisplayedLocations.Count;
                
            }
            var textLine = Instantiate(EncounterButton);
            textLine.transform.SetParent(GridLayoutPanel.transform);
            textLine.GetComponentInChildren<Text>().text = loc.Name;
            DisplayedLocations.Add(textLine);
        }
    }
    private void UpdateEncountersListAlt()
    {
        //create list of locations that are no longer visible
        var displayedLocations = DisplayedLocations.Select(x => x.GetComponent<Location>());

        var displayedNotVisibleLocs = displayedLocations.Except<Location>(Detector.VisibleLocations);
        var locationsToBeDisplayed = Detector.VisibleLocations.Except(displayedLocations);
        //check if not null
        if (displayedNotVisibleLocs != null)
        {
            //true: delete GO's
            foreach (var line in displayedNotVisibleLocs)
            {
                line.gameObject.SetActive(false);
                DisplayedLocations.Remove(line.gameObject);
                Destroy(line.gameObject);
            }
        }

        if (locationsToBeDisplayed != null)
        {
            foreach(var loc in locationsToBeDisplayed)
            {
                CreateEncounterLine(loc);
            }
        }
    }

    private void CreateEncounterLine(Location loc)
    {
        var isBoo = Detector.VisibleLocations.IndexOf(loc);
        if (isBoo >= DisplayedLocations.Count)
        {
            var additionalLines = Detector.VisibleLocations.Count - DisplayedLocations.Count;

        }
        var textLine = Instantiate(EncounterButton);
        textLine.transform.SetParent(GridLayoutPanel.transform);
        textLine.GetComponentInChildren<Text>().text = loc.Name;
        DisplayedLocations.Add(textLine);
    }
}
