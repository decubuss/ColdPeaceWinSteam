using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestinationMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private RectTransform TransformSelf;
    [SerializeField]
    public RectTransform DestinationTransform;
    [SerializeField]
    private RocketSleighEngine Engine;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = DestinationTransform.localPosition - TransformSelf.localPosition;
        float distance = Vector3.Distance(TransformSelf.localPosition,
                                          DestinationTransform.localPosition);
        if (distance > 0)
        {
            Vector3 newPosition = 
                TransformSelf.localPosition + 
                (direction.normalized * Engine.MoveSpeed * Time.deltaTime);
            TransformSelf.localPosition = newPosition;
        }
    }
}
