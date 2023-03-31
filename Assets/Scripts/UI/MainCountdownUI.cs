using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MainCountdownUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text HoursText;
    [SerializeField]
    private Text MinutesText;
    [SerializeField]
    private Text SecondsText;

    [SerializeField]
    private EnviromentInputs EnviromentInputs; 

    private float StormInitial = 0;
    private void Awake()
    {
        StormInitial = EnviromentInputs.TimeBeforeStormGlobal;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StormInitial -= 1 * Time.deltaTime;
        HoursText.text = HoursDisplay(TimeSpan.FromSeconds((double)StormInitial));
        MinutesText.text = MinutesDisplay(TimeSpan.FromSeconds((double)StormInitial));
        SecondsText.text = SecondsDisplay(TimeSpan.FromSeconds((double)StormInitial));
    }

    private string HoursDisplay(TimeSpan span)
    {
        return string.Format("{0}",
                 (int)span.TotalHours);
    }
    private string MinutesDisplay(TimeSpan span)
    {
        return string.Format(": {0} :",
                 (int)span.Minutes);
    }
    private string SecondsDisplay(TimeSpan span)
    {
        return string.Format("{0}",
                 (int)span.Seconds);
    }
}
