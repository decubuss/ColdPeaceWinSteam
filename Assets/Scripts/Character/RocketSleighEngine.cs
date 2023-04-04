using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EngineLoad
{
    NotRunning,
    Optimal,
    High,
    VeryHigh,
    Extreme
}
public class RocketSleighEngine : MonoBehaviour
{
    [SerializeField]
    public int EngineHealth = 100;
    [SerializeField]
    public float MoveSpeed = 10f;
    //[SerializeField]
    //private EngineLoadDisplayer EngineLoadDisplayer;

    public bool isNotRunning = true;
    public bool isOptimaLoad = false;
    public bool isHighLoad = false;
    public bool isVeryHighLoad = false;
    public bool isExtremeLoad = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNotRunning == true) { MoveSpeed = 0f; }
    }

    public void OptimalHandler(bool isOn)
    {
        isOptimaLoad = isOn;
        //Debug.Log("Optimal da value is " + OptimalToggle.isOn);
    }
    public void HighHandler(bool isOn)
    {
        isHighLoad = isOn;
        //Debug.Log("High da value is " + HighToggle.isOn);
    }
    public void VeryHighHandler(bool isOn)
    {
        isVeryHighLoad = isOn;
        //Debug.Log("Very High da value is " + VeryHighToggle.isOn);
    }
    public void ExtremeHandler(bool isOn)
    {
        isExtremeLoad = isOn;
        //Debug.Log("Extreme da value is " + ExtremeToggle.isOn);
    }

}
