using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPin : MonoBehaviour
{
    [SerializeField]
    private bool _isReached;

    public bool IsReached
    {
        get { return _isReached; }
        set { _isReached = value; }
    }

}
