using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chauffeur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EncounterDetector.OnEncounterListUpdated += AddAvaiableEncounter;//TODO: replace it, the logic is  not solid
        //it should be event of arrival in here
        //visible objects are poppin off in table when visible
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void AddAvaiableEncounter()
    {
        //Debug.Log("the encounter available");
    }
}
