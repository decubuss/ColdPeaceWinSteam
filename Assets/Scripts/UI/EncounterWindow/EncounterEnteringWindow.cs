using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EncounterEnteringWindow : MonoBehaviour
{
    [SerializeField]
    private Location _encounter;
    [SerializeField]
    public Location Encounter
    {
        get
        {
            return _encounter;
        }
        set
        {
            if (_encounter == null) 
            {
                _encounter = value;
                LocationSet();
            }
            _encounter = value; 
        }

    }

    [SerializeField]
    private TextMeshProUGUI EncounterTitle;
    [SerializeField]
    private TextMeshProUGUI EncounterEnteringText;
    [SerializeField]
    private TextMeshProUGUI EncounterCost;

    void Update()
    {
        //HideIfClickedOutside();
    }

    private void HideIfClickedOutside()
    {
        var panel = gameObject;
        if (Input.GetMouseButton(0) && panel.activeSelf &&
            !RectTransformUtility.RectangleContainsScreenPoint(
                panel.GetComponent<RectTransform>(),
                Input.mousePosition,
                Camera.main))
        {
            HideWindow();
            Debug.Log("wowo");
        }
    }
    private void LocationSet()
    {
        EncounterTitle.text = Encounter.Name;
        EncounterEnteringText.text = CreateEnteringText(Encounter.Name);
        EncounterCost.text = CreateEnteringCostText(Encounter.enteringCost);
    }

    private string CreateEnteringText(string encounterName)
    {
        string enteringText = "Stop by and search " + encounterName + "?";
        return enteringText;
    }

    private string CreateEnteringCostText(int cost)
    {
        string costText = "Cost: " + cost.ToString() + " minutes";
        return costText;
    }

    public void HideWindow()
    {
        gameObject.SetActive(false);
    }
    public void EnterEncounter()
    {
        HideWindow();
        CanvasesKeeperSingleton.OpenEncounter();
    }
}
