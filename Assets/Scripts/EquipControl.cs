using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipControl : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private GameObject prefab;
    [SerializeField] private PlayerEquip playerEquip;
    [SerializeField] private ShowEquip showEquip;
    public void UpdateInventoryUI(List<EquipMessage> items, int page, int itemsPerPage)
    {
        foreach (Transform child in parent)
        {
            Destroy(child.gameObject);
        }

        int startIndex = page * itemsPerPage;
        int endIndex = Mathf.Min(startIndex + itemsPerPage, items.Count);

        for (int i = startIndex; i < endIndex; i++)
        {
            GameObject newIcon = Instantiate(prefab, parent);
            newIcon.GetComponent<Equip>().SetIcon(items[i].bagSprite);

            int index = i;
            newIcon.GetComponent<Button>().onClick.AddListener(() =>
            {
                playerEquip.ChangeEquip(items[index]);
                showEquip.ChangeShowEquip(items[index]);
            });
        }
    }
}
