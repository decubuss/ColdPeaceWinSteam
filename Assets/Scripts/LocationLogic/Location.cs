using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EncounterType
{
    armedCell,
    randomInanimate,
    randomAnimate
}
public class Location : MonoBehaviour
{
    [SerializeField]
    private string _name;
    [SerializeField]
    public string Name
    {
        get
        {
            if (isRevealed) return _name;
            else return "unknown";
        }
        set { _name = value; }
    }

    protected EncounterType EncounterType = EncounterType.armedCell;

    [SerializeField]
    [Tooltip("For encounters, time on interaction not included")]
    public int enteringCost = 0;

    private bool isRevealed = true;
    private void Awake()
    {
        switch (EncounterType)
        {
            case EncounterType.armedCell:
                enteringCost = 5;
                break;
            case EncounterType.randomInanimate:
                enteringCost = 10;
                break;
            case EncounterType.randomAnimate:
                enteringCost = 5;
                break;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
