using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EncounterEnteringWindow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextMeshProUGUI EncounterTitle;
    [SerializeField]
    private TextMeshProUGUI EncounterEnteringText;
    [SerializeField]
    private TextMeshProUGUI EncounterCost;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HideIfClickedOutside();
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
            panel.SetActive(false);
        }
    }
    private void OnEnable()
    {
        
    }
}
