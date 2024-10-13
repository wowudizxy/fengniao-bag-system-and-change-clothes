using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEquip : MonoBehaviour
{
    [SerializeField] private Image headWearSlot;
    [SerializeField] private Image coatSlot;
    [SerializeField] private Image shoeSlot;
    [SerializeField] private Image liningSlot;
    [SerializeField] private Image ButtomSlot;
    [SerializeField] private DefaultEquipSO defaultEquipSO;
    private void Start()
    {
        EqualDefault();
    }

    private void EqualDefault()
    {
        headWearSlot.sprite = defaultEquipSO.defaultEquip[0].showHeadWear;
        coatSlot.sprite = defaultEquipSO.defaultEquip[0].showCoat;
        shoeSlot.sprite = defaultEquipSO.defaultEquip[0].showShoe;
        liningSlot.sprite = defaultEquipSO.defaultEquip[0].showLining;
        ButtomSlot.sprite = defaultEquipSO.defaultEquip[0].showButtom;
    }
    public void ChangeShowEquip(EquipMessage equipMessage)
    {
        switch (equipMessage.type)
        {
            case EquipMessage.TYPE.HeadWear:
                headWearSlot.sprite = equipMessage.bagSprite;
                break;
            case EquipMessage.TYPE.Lining:
                liningSlot.sprite = equipMessage.bagSprite;
                break;
            case EquipMessage.TYPE.Coat:
                coatSlot.sprite = equipMessage.bagSprite;
                break;
            case EquipMessage.TYPE.Buttom:
                ButtomSlot.sprite = equipMessage.bagSprite;
                break;
            case EquipMessage.TYPE.Shoe:
                shoeSlot.sprite = equipMessage.bagSprite;
                break;
            default:
                break;
        }
    }
}
