using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Standart Item", fileName = "New Item")]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField]
    private Sprite _iconItem;
    [SerializeField]
    private float _attack;
    [SerializeField]
    private float _defence;
    public enum ItemType {body, hand }
    [SerializeField] private ItemType _type;

    public new ItemType GetType()
    {
        return _type;
    }

    public float GetAttack()
    {
        return _attack;
    }

    public float GetDefence()
    {
        return _defence;
    }

    public string GetName()
    {
        return _name;
    }
}
