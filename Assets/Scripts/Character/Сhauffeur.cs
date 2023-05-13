using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Сhauffeur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EncounterDetector.onEncounterVisible += AddAvaiableEncounter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void AddAvaiableEncounter()
    {
        Debug.Log("the encounter available");
    }
}
