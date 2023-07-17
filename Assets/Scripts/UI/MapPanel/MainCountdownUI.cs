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

    private float StormTimer = 0;
    private void Awake()
    {
        StormTimer = EnviromentInputs.TimeBeforeStormGlobal;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StormTimer -= 1 * Time.deltaTime;//cant throw the timer from Environment class - it dispalyas wrong, this one working so far
        HoursText.text = HoursDisplay(TimeSpan.FromSeconds((double)StormTimer));
        MinutesText.text = MinutesDisplay(TimeSpan.FromSeconds((double)StormTimer));
        SecondsText.text = SecondsDisplay(TimeSpan.FromSeconds((double)StormTimer));
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
