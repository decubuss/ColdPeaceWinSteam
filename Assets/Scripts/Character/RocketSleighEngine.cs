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
    public float CurrentTopSpeed = 0f;
    [SerializeField]
    public float TopSpeedReachTime = 100f;
    [SerializeField]
    public float DecreasedSpeedReachTime = 10f;

    [SerializeField]
    public int EngineHealth = 100;
    
    [SerializeField]
    private EngineLoad _engineLoad;

    public bool isNotRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        _engineLoad = EngineLoad.NotRunning;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveSpeed < CurrentTopSpeed && _engineLoad != EngineLoad.NotRunning)
        {
            var acceleration = (CurrentTopSpeed - 0) / /*delta speed*/
                               (TopSpeedReachTime - 0f); //delta time
            MoveSpeed += acceleration * Time.deltaTime;
        }
        else if (MoveSpeed == CurrentTopSpeed)
            MoveSpeed = CurrentTopSpeed;
        else if (MoveSpeed > CurrentTopSpeed)
        {
            var decceleration = (MoveSpeed - CurrentTopSpeed) / /*delta speed*/
                                (DecreasedSpeedReachTime - 0f); //delta time
            MoveSpeed -= decceleration * Time.deltaTime;
        }
    }

    public void OptimalHandler(bool isOn)
    {
        if (isOn)
            _engineLoad = EngineLoad.Optimal;
        else
            _engineLoad = EngineLoad.NotRunning;
        ChangeSpeed();
    }
    public void HighHandler(bool isOn)
    {
        if (isOn)
            _engineLoad = EngineLoad.High;
        else
            _engineLoad = EngineLoad.Optimal;
        ChangeSpeed();
    }
    public void VeryHighHandler(bool isOn)
    {
        if (isOn)
            _engineLoad = EngineLoad.VeryHigh;
        else
            _engineLoad = EngineLoad.High;
        ChangeSpeed();
    }
    public void ExtremeHandler(bool isOn)
    {
        if (isOn)
            _engineLoad = EngineLoad.Extreme;
        else
            _engineLoad = EngineLoad.VeryHigh;
        ChangeSpeed();
    }
    private void ChangeSpeed()
    {
        switch (_engineLoad)
        {
            case EngineLoad.NotRunning:
                CurrentTopSpeed = 0f;
                //MoveSpeed = 0f;
                break;
            case EngineLoad.Optimal:
                CurrentTopSpeed = 10f;
                //MoveSpeed = 10f;
                break;
            case EngineLoad.High:
                CurrentTopSpeed = 20f;
                //MoveSpeed = 20f;
                break;
            case EngineLoad.VeryHigh:
                CurrentTopSpeed = 40f;
                //MoveSpeed = 40f;
                break;
            case EngineLoad.Extreme:
                CurrentTopSpeed = 80f;
                //MoveSpeed = 80f;
                break;
        }
    }
    private void ChangeAcceleration()
    {

    }

    public void FullHalt()
    {
        _engineLoad = EngineLoad.NotRunning;
        MoveSpeed = 0;
        isNotRunning = true;
    }

}
