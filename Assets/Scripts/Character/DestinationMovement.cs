using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestinationMovement : MonoBehaviour
{
    [Header("Sleigh Elements")]
    [SerializeField]
    private RocketSleighEngine Engine;
    [SerializeField]
    private EncounterDetector EncounterDetector;


    [SerializeField]
    private RectTransform TransformSelf;
    [SerializeField]
    public RectTransform DestinationTransform;

    void Start()
    {
        if(!TransformSelf) TransformSelf = gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = DestinationTransform.localPosition - TransformSelf.localPosition;
        float distance = Vector3.Distance(TransformSelf.localPosition,
                                          DestinationTransform.localPosition);
        //TODO - add movemnt after destination changes
        if (distance > 0.5f)
        {
            Vector3 newPosition = 
                TransformSelf.localPosition + 
                (direction.normalized * Engine.MoveSpeed * Time.deltaTime);
            TransformSelf.localPosition = newPosition;
        }
        else
        {
            EncounterDetector.FindClosestEncounter();
            Engine.FullHalt();
            DestinationTransform.GetComponent<DestinationPin>().IsReached = true;
        }
    }
    //TODO: check or event triggers for different occastions if locations is actually real and ocuppied/visible
}
