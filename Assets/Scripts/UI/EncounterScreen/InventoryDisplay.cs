using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class InventoryDisplay : MonoBehaviour
{
    [SerializeField]
    public GameObject CaptivesA;
    [SerializeField]
    public GameObject SuppliesFromA;
    [SerializeField]
    public GameObject IntelForA;
    [SerializeField]
    public GameObject Heaters;
    [SerializeField]
    public GameObject Medics;
    [SerializeField]
    public GameObject CaptivesB;
    [SerializeField]
    public GameObject SuppliesFromB;
    [SerializeField]
    public GameObject IntelForB;


    public void UpdateDisplayCount(GameObject inventoryCell, int updatedCount)
    {
        inventoryCell.transform.Find("Count")
            .GetComponent<TextMeshProUGUI>()//yeah, we could store actually but may be color control is needed
            .text = updatedCount.ToString();
    }
}
