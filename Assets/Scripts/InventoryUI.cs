using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private AllBagSO allBagSO;
    [SerializeField] private EquipControl equipControl;
    public int itemsPerPage = 14;
    private int currentPage = 0;
    private EquipMessage.TYPE type = EquipMessage.TYPE.All;
    [SerializeField] private TextMeshProUGUI pageText;
    public void NextPage()
    {
        if ((currentPage + 1) * itemsPerPage < GetFilteredItems().Count)
        {
            currentPage++;
            RefreshUI();
        }
    }

    public void PreviousPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
            RefreshUI();
        }
    }

    public void SetType(EquipMessage.TYPE newType)
    {
        type = newType;
        currentPage = 0; 
    }

    public void RefreshUI()
    {
        List<EquipMessage> filteredItems = GetFilteredItems();
        equipControl.UpdateInventoryUI(filteredItems, currentPage, itemsPerPage);
        pageText.text = currentPage+1 + "/30";
    }

    private List<EquipMessage> GetFilteredItems()
    {
        if (type == EquipMessage.TYPE.All)
            return allBagSO.bagMessages;

        List<EquipMessage> filteredItems = new List<EquipMessage>();
        foreach (var item in allBagSO.bagMessages)
        {
            if (item.type == type)
            {
                filteredItems.Add(item);
            }
        }
        return filteredItems;
    }
}
