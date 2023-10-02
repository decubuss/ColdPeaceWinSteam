using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncounterEnteringWindow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text EncounterTitle;
    [SerializeField]
    private Text EncounterEnteringText;
    [SerializeField]
    private Text EncounterEnteringText;
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
