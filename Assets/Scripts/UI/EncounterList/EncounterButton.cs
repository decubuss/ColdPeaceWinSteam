using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EncounterButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Location Encounter;

    [SerializeField]
    private Text buttonText;
    [SerializeField]
    private GameObject EncounterPanel;
    private Transform EncounterPanelParent;
    
    private void Awake()
    {
        if (!EncounterPanel) { EncounterPanel = GameObject.Find("EncounterEnteringWindow"); }
        if (!EncounterPanelParent) { EncounterPanelParent = GameObject.Find("CabinPanel").transform; }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public EncounterButton(Location location,Text text)
    //{
    //    Location = location;
    //    buttonText = text; //TODO: text changes upon fully discovering, Kenshi-vise
    //}

    /// <summary>
    /// Method calls
    /// </summary>
    public void CallEncounterWindow()
    {
        //TODO: call a window, that asks: Proceed or Decline with encounter 
        var window = Instantiate(EncounterPanel, 
                    EncounterPanelParent.TransformPoint(0,0,0), 
                    Quaternion.identity, 
                    EncounterPanelParent);
        window.GetComponent<EncounterEnteringWindow>().Encounter = Encounter;
    }
}
