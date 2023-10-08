using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasesKeeperSingleton : MonoBehaviour
{
    public static GameObject MapCanvas;
    public static GameObject EncounterCanvas;
    public static Location CurrentLocation;
    private void Awake()
    {
        MapCanvas = GameObject.Find("MapCanvas");
        EncounterCanvas = GameObject.Find("EncounterCanvas");
    }

    private void Start()
    {
        if (MapCanvas != null) Debug.Log(MapCanvas);
        if (EncounterCanvas != null)
        {
            EncounterCanvas.SetActive(false);        }
    }

    public static void OpenMap()
    {
        EncounterCanvas.SetActive(false);
        MapCanvas.SetActive(true);
    }

    public static void OpenEncounter(/*Location encounter*/)
    {
        MapCanvas.SetActive(false);
        EncounterCanvas.SetActive(true);
    }
}
