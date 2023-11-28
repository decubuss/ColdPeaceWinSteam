using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSleighInventory : MonoBehaviour
{
    #region The Slots
    [Header("Inventory digits")]
    public int captivesA;
    public int CaptivesA
    {
        get
        {
            return captivesA;
        }
        set
        {
            captivesA = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.CaptivesA, captivesA);
        }
    }

    public int captivesB;
    public int CaptivesB
    {
        get
        {
            return captivesB;
        }
        set
        {
            captivesB = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.CaptivesB, captivesB);
        }
    }

    public int suppliesFromA;
    public int SuppliesFromA
    {
        get
        {
            return suppliesFromA;
        }
        set
        {
            suppliesFromA = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.SuppliesFromA, suppliesFromA);
        }
    }

    public int suppliesFromB;
    public int SuppliesFromB
    {
        get
        {
            return suppliesFromB;
        }
        set
        {
            suppliesFromB = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.SuppliesFromB, suppliesFromB);
        }
    }

    public int intelForA;
    public int IntelForA
    {
        get
        {
            return intelForA;
        }
        set
        {
            intelForA = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.IntelForA, intelForA);
        }
    }

    public int intelForB;
    public int IntelForB
    {
        get
        {
            return intelForB;
        }
        set
        {
            intelForB = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.IntelForB, intelForB);
        }
    }

    public int medics;
    public int Medics
    {
        get
        {
            return medics;
        }
        set
        {
            medics = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.Medics, medics);
        }
    }

    public int heaters;
    public int Heaters
    {
        get
        {
            return heaters;
        }
        set
        {
            heaters = value;
            InventoryDisplay.UpdateDisplayCount(InventoryDisplay.Heaters, heaters);
        }
    }
    #endregion

    #region UI
    [Header("UI elements")]
    [SerializeField]
    private InventoryDisplay InventoryDisplay;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
