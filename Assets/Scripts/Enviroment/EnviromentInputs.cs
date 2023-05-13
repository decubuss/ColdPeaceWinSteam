using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeatherConditions
{
    Clear,
    SemiClear,
    WhiteOut
}

public class EnviromentInputs : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float IncomingStormTime = 2592;
    public float TimeBeforeStormGlobal;

    [SerializeField]
    public float СurrentVisibilityRange = 10f;
    [SerializeField]
    public RectTransform[] ArmedForcesCells;

    public delegate void WeatherChange();
    public static event WeatherChange onWeatherChange;

    private WeatherConditions _weather;
    [SerializeField]
    public WeatherConditions Weather
    {
        get { return _weather; }
        set 
        { 
            _weather = value;
            onWeatherChange();
        }
    }

    //[SerializeField]
    private float ClearWeatherVisRange = 5f;//5 kilometers is a human sight radius visible range
    //[SerializeField]
    //private float SnowyWeatherVisRange = 2f;
    //[SerializeField]
    //private float WhiteoutVisRange = 0.4f;
    void Start()
    {
        СurrentVisibilityRange = ClearWeatherVisRange;
        TimeBeforeStormGlobal = IncomingStormTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeBeforeStormGlobal -= 1 * Time.deltaTime; ;
    }

    private void ChangeWeather()
    {
        switch (Weather)
        {
            //case WeatherConditions.Clear:
            //    CurrentTopSpeed = 0f;
            //    break;
            
        }
    }

  
}
