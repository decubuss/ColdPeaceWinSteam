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

    private List<(Location,GameObject)> DisplayedLocationButtons = new List<(Location, GameObject)>();
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
    
    private void UpdateEncountersListAlt()
    {
        //create list of locations that are no longer visible
        List<Location> displayedLocations = DisplayedLocationButtons.Select(x => x.Item1)
                                            .ToList();

        List<Location> displayedNotVisibleLocs = displayedLocations.Except<Location>(Detector.VisibleLocations)
                                                 .ToList();
        List<Location> locationsToBeDisplayed = Detector.VisibleLocations.Except(displayedLocations)
                                                .ToList();
        //check if not null
        DestroyInvisibleLocationLines(displayedNotVisibleLocs);

        if (locationsToBeDisplayed.Count() > 0)
        {
            foreach (var loc in locationsToBeDisplayed)
            {
                CreateEncounterLine(loc);
            }
        }
    }

    private void DestroyInvisibleLocationLines(List<Location> displayedNotVisibleLocs)
    {
        if (displayedNotVisibleLocs.Count() > 0)
        {
            //true: delete GO's
            foreach (var line in displayedNotVisibleLocs)
            {
                var buttonsTemp = DisplayedLocationButtons.Where(x => x.Item1 == line)
                                                          .Select(x=> x.Item2).ToList();
                DisplayedLocationButtons.RemoveAll(x => x.Item1 == line);
                foreach(var button in buttonsTemp) { Destroy(button); }
            }
        }
    }

    private void CreateEncounterLine(Location loc)
    {
        var encButton = Instantiate(EncounterButton);
        encButton.transform.SetParent(GridLayoutPanel.transform);
        encButton.GetComponentInChildren<Text>().text = loc.Name;
        DisplayedLocationButtons.Add((loc, encButton));
    }
}
