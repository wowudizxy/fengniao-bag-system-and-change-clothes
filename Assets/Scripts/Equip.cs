using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equip : MonoBehaviour
{
    [SerializeField] private Image iconSprite;

    public void SetIcon(Sprite sprite)
    {
        iconSprite.sprite = sprite;
    }
    
}
