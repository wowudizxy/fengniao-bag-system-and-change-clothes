using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class AllBagSO : ScriptableObject
{
    public List<EquipMessage> bagMessages;
    
}
[Serializable]
public class EquipMessage 
{
    public string name;
    public Sprite bagSprite;
    public Sprite clothesSprite;
    public string description;
    public enum TYPE
    {
        All,Suit,HeadWear,Lining,Coat,Buttom,Shoe,Prop
    }
    public TYPE type;
}

