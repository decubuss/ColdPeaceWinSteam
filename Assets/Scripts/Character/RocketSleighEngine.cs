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
    public float MoveSpeed = 0f;
    [SerializeField]
    public float CurrentTopSpeed = 15f;
    [SerializeField]
    public float TopSpeedReachTime = 100f;

    [SerializeField]
    public int EngineHealth = 100;
    
    [SerializeField]
    private EngineLoad EngineLoad;
    //[SerializeField]
    //private EngineLoadDisplayer EngineLoadDisplayer;

    public bool isNotRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isNotRunning == true) { MoveSpeed = 0f; }
    }

    public void OptimalHandler(bool isOn)
    {
        if (isOn)
            EngineLoad = EngineLoad.Optimal;
        else
            EngineLoad = EngineLoad.NotRunning;
        ChangeSpeed();
    }
    public void HighHandler(bool isOn)
    {
        if (isOn)
            EngineLoad = EngineLoad.High;
        else
            EngineLoad = EngineLoad.Optimal;
        ChangeSpeed();
    }
    public void VeryHighHandler(bool isOn)
    {
        if (isOn)
            EngineLoad = EngineLoad.VeryHigh;
        else
            EngineLoad = EngineLoad.High;
        ChangeSpeed();
    }
    public void ExtremeHandler(bool isOn)
    {
        if (isOn)
            EngineLoad = EngineLoad.Extreme;
        else
            EngineLoad = EngineLoad.VeryHigh;
        ChangeSpeed();
    }
    private void ChangeSpeed()
    {
        switch (EngineLoad)
        {
            case EngineLoad.NotRunning:
                MoveSpeed = 0f;
                break;
            case EngineLoad.Optimal:
                MoveSpeed = 10f;
                break;
            case EngineLoad.High:
                MoveSpeed = 20f;
                break;
            case EngineLoad.VeryHigh:
                MoveSpeed = 40f;
                break;
            case EngineLoad.Extreme:
                MoveSpeed = 80f;
                break;
        }
    }
    private void ChangeAcceleration()
    {

    }

}
