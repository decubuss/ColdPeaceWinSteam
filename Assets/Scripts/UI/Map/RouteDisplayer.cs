using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class RouteDisplayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private RectTransform StartPoint;
    [SerializeField]
    public RectTransform EndPoint;
    [SerializeField]
    private LineRenderer Line;
    void Start()
    {
        Line.SetPosition(0, StartPoint.position + new Vector3(0,0,-1));
        Line.SetPosition(1, EndPoint.position);
    }

    // Update is called once per frame
    void Update()
    {
        Line.SetPosition(0, StartPoint.position + new Vector3(0, 0, -1));
        Line.SetPosition(1, EndPoint.position);
    }
}
