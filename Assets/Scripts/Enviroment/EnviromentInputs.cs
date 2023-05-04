using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentInputs : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float TimeBeforeStormGlobal = 2592;
    [SerializeField]
    public float СurrentVisibilityRange = 10f;
    [SerializeField]
    public RectTransform[] ArmedForcesCells;

    [SerializeField]
    private float ClearWeatherVisRange = 5f;//5 kilometers is a human sight radius visible range
    [SerializeField]
    private float SnowyWeatherVisRange = 2f;
    [SerializeField]
    private float WhiteoutVisRange = 0.4f;
    void Start()
    {
        СurrentVisibilityRange = ClearWeatherVisRange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
