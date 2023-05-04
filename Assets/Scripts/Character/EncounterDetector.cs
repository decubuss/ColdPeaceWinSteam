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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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

        return Environement.ArmedForcesCells[closestPointIndex];
    }
}
