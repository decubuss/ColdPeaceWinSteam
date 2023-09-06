using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeResourceDisplay : MonoBehaviour
{
    [SerializeField]
    private Text MinutesText;
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
    void FixedUpdate()
    {
        StormTimer -= 1 * Time.deltaTime;//TODO: make subtraction: on the move and after decesion made
        MinutesText.text = MinutesDisplay(TimeSpan.FromSeconds((double)StormTimer));
    }
    private string MinutesDisplay(TimeSpan span)
    {
        return string.Format("{0}",
                 (int)span.TotalMinutes);
    }
}
