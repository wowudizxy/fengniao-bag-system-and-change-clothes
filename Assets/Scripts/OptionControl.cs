using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionControl : MonoBehaviour
{
    [SerializeField] private InventoryUI inventoryUI;
    [SerializeField] private List<Toggle> toggles;
    [SerializeField] private List<GameObject> selectedIndicators;
    [SerializeField] private List<EquipMessage.TYPE> types;

    private void Start()
    {
        OnToggleChanged(true, 0);
        for (int i = 0; i < toggles.Count; i++)
        {
            int index = i;
            toggles[index].onValueChanged.AddListener((isOn) => OnToggleChanged(isOn, index));
        }
    }

    private void OnToggleChanged(bool isOn, int index)
    {
        if (isOn)
        {
            inventoryUI.SetType(types[index]);
            inventoryUI.RefreshUI();
            selectedIndicators[index].SetActive(true);
        }
        else
        {
            selectedIndicators[index].SetActive(false);
        }
    }

    private void OnDestroy()
    {
        foreach (var toggle in toggles)
        {
            toggle.onValueChanged.RemoveAllListeners();
        }
    }
}
