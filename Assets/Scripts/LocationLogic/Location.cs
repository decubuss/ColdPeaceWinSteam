using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isRevealed = true;
    [SerializeField]
    private string _name;
    [SerializeField]
    public string Name
    {
        get
        {
            if (isRevealed) return _name;
            else return "unknown";
        }
        set { _name = value; }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
