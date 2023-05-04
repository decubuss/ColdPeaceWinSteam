using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPin 
{
    [SerializeField]
    private bool _isReached;

    public bool IsReached
    {
        get { return _isReached; }
        set { IsReached = value; }
    }

}
