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
        //print("I was clicked");
        //print(eventData.position);
        Debug.Log(localSpace.InverseTransformPoint(eventData.position));
        var desiredPosition = localSpace.InverseTransformPoint(eventData.position);
        //DestinationPin.rectTransform.parent = null;
        DestinationPin.rectTransform.localPosition = desiredPosition;
        //TODO: fix localspace convertion it is nnot working at the moment
        //DestinationPin.rectTransform.localPosition = MapImage.rectTransform.InverseTransformPoint((Vector3)eventData.position);
    }
}
