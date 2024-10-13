using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class DefaultEquipSO : ScriptableObject
{
    public List<TypeEquip> defaultEquip;
}
[Serializable]
public class TypeEquip
{
    public Sprite headWear;
    public Sprite lining;
    public Sprite buttom;
    public Sprite coat;
    public Sprite shoe;
    public Sprite showHeadWear;
    public Sprite showLining;
    public Sprite showButtom;
    public Sprite showCoat;
    public Sprite showShoe;
}
