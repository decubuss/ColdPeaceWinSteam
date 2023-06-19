using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;



public class EncounterDetector : MonoBehaviour
{
    [SerializeField]
    private EnviromentInputs Environement;
    [SerializeField]
    private RectTransform TransformSelf;
    [SerializeField]
    private float _detectionRange = 5f;

    public List<Location> VisibleLocations;
    
    public delegate void EncounterListUpdated();
    public static event EncounterListUpdated OnEncounterListUpdated;

    void OnEnable()
    {
        EnviromentInputs.onWeatherChange += DetectionRangeUpdate;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindVisibleEncounters();
    }

    private void DetectionRangeUpdate()
    {

    }

    public RectTransform FindClosestEncounter()
    {
        var points = Environement.ArmedForcesCells.Select(y => (Vector2) y.localPosition)
                                                  .ToArray();
        if (points == null || points.Length == 0)
            throw new ArgumentException("Points array must contain at least one point");

        int closestPointIndex = 0;
        Vector2 closestPoint = points[closestPointIndex];
        float closestDistance = Vector2.Distance(transform.localPosition, closestPoint);

        for (int i = 0; i < points.Length; i++)
        {
            float distance = Vector2.Distance(TransformSelf.localPosition, points[i]);
            if (distance < closestDistance)
            {
                closestPoint = points[i];
                closestDistance = distance;
                closestPointIndex = i;
            }
        }

        if (closestDistance <= _detectionRange) OnEncounterListUpdated();
        return Environement.ArmedForcesCells[closestPointIndex];
    }

    private void FindVisibleEncounters()
    {
        var points = Environement.ArmedForcesCells.ToArray();
        for (int i = 0; i < points.Length; i++)
        {
            float distance = Vector2.Distance(TransformSelf.localPosition, points[i].localPosition);
            var location = points[i].GetComponent<Location>();
            var isLocationInList = VisibleLocations.Contains(location);
            if (distance < _detectionRange && location != null && !isLocationInList)
            {
                Debug.Log("there is a " + location.name + " nearby");
                VisibleLocations.Add(location);
                OnEncounterListUpdated();
            }
        }
        FindNotVisibleEncounters();
    }
    
    private void FindNotVisibleEncounters()
    {
        foreach(var loc in VisibleLocations)
        {
            float distance = Vector2.Distance(TransformSelf.localPosition, 
                                              loc.gameObject.transform.localPosition);
            if (distance > _detectionRange)
            {
                VisibleLocations.Remove(loc);
                OnEncounterListUpdated();
            }
        }
    }
}
