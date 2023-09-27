using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncounterButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Location Location;
    private Text buttonText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public EncounterButton(Location location,Text text)
    {
        Location = location;
        buttonText = text; //TODO: text changes upon fully discovering, Kenshi-vise
    }

    /// <summary>
    /// Method calls
    /// </summary>
    public static void CallEncounterWindow()
    {
        //TODO: call a window, that asks: Proceed or Decline with encounter 
    }
}
