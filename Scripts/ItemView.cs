using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemView : MonoBehaviour
{
    [SerializeField] private ItemData[] _allItems;

    public ItemData[] GetItemData()
    {
        return _allItems;
    }

    public ItemData GetItemData(string name)
    {
        foreach(ItemData data in _allItems)
        {
            if(data.name == name)
            {
                return data;
            }
        }
        return null;
    }

}
