using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEquip : MonoBehaviour
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
        headWearSlot.sprite = defaultEquipSO.defaultEquip[0].headWear;
        coatSlot.sprite = defaultEquipSO.defaultEquip[0].coat;
        shoeSlot.sprite = defaultEquipSO.defaultEquip[0].shoe;
        liningSlot.sprite = defaultEquipSO.defaultEquip[0].lining;
        ButtomSlot.sprite = defaultEquipSO.defaultEquip[0].buttom;
    }
    public void ChangeEquip(EquipMessage equipMessage)
    {
        switch (equipMessage.type)
        {
            case EquipMessage.TYPE.HeadWear:
                headWearSlot.sprite = equipMessage.clothesSprite;
                break;
            case EquipMessage.TYPE.Lining:
                liningSlot.sprite = equipMessage.clothesSprite;
                break;
            case EquipMessage.TYPE.Coat:
                coatSlot.sprite = equipMessage.clothesSprite;
                break;
            case EquipMessage.TYPE.Buttom:
                ButtomSlot.sprite = equipMessage.clothesSprite;
                break;
            case EquipMessage.TYPE.Shoe:
                shoeSlot.sprite = equipMessage.clothesSprite;
                break;
            default:
                break;
        }
    }
}
