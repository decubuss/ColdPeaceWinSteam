using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InteractiveMap : MonoBehaviour, IPointerClickHandler
{

    // Start is called before the first frame update
    [SerializeField]
    private Image MapImage;
    [SerializeField]
    private Image DestinationPin;
    [SerializeField]
    private RectTransform localSpace;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData) // 3
    {
        var desiredPosition = localSpace.InverseTransformPoint(eventData.position);
        DestinationPin.rectTransform.localPosition = desiredPosition;
        NewDestinationSet();
    }

    private void NewDestinationSet()
    {
        //TODO: add distance check between Sleigh and Dest
        DestinationPin.GetComponent<DestinationPin>().IsReached = false;
    }
}
