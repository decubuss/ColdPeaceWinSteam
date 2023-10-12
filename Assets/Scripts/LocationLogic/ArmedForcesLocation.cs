using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmedForcesLocation : Location
{
    
    [Tooltip("will to continue fight, the logic behind continuing doing the job")]
    [SerializeField]
    private float _battleMorale;
    [Tooltip("thoughts and reasoning behind selfpreservation, undearstanding that you are on your own")]
    [SerializeField]
    private float _selfPreservation;
    [Tooltip("level of acceptance of non-conventional decisions, reverse level of hostility")]
    [SerializeField]
    private float _mentalAgility;
    [Tooltip("level of acceptance of AF organization and duties")]
    [SerializeField]
    private float _discipline;
    public float BattleMorale
    {
        get
        {
            return _battleMorale;
        }
        set
        {
            _battleMorale = value;
        }
    }
    public float SelfPreservation
    {
        get
        {
            return _selfPreservation;
        }
        set
        {
            _selfPreservation = value;
        }
    }
    public float MentalAgility
    {
        get
        {
            return _mentalAgility;
        }
        set
        {
            _mentalAgility = value;
        }
    }
    public float Discipline
    {
        get
        {
            return _discipline;
        }
        set
        {
            _discipline = value;
        }
    }
    public void Arrival()
    {
        
    }

    
}
