﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineLoadDisplayer : MonoBehaviour
{
    [SerializeField]
    private Toggle OptimalToggle;
    [SerializeField]
    private Toggle HighToggle;
    [SerializeField]
    private Toggle VeryHighToggle;
    [SerializeField]
    private Toggle ExtremeToggle;

    [SerializeField]
    private RocketSleighEngine SleighEngine;

    public EngineLoad EngineLoad = EngineLoad.NotRunning;
    // Start is called before the first frame update
    void Start()
    {
        OptimalToggle.onValueChanged.AddListener(SleighEngine.OptimalHandler);
        HighToggle.onValueChanged.AddListener(SleighEngine.HighHandler);
        VeryHighToggle.onValueChanged.AddListener(SleighEngine.VeryHighHandler);
        ExtremeToggle.onValueChanged.AddListener(SleighEngine.ExtremeHandler);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
