using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour
{
    [SerializeField] 
    private Transform _backpack;
    [SerializeField] 
    private GameObject _itemPref;
    [SerializeField]
    private List<GameObject> _allPackItem;
    [SerializeField] 
    private ViewBase _viewBase;

    private void Start()
    {
        FillBackpack();
    }

    private void FillBackpack()
    {
        var itemCount = _viewBase.GetItemCount();
        for (int i = 0; i < itemCount; i++)
        {
            var itemName = _viewBase.GetItem(i);
            var data = _viewBase.GetItemData(itemName);
            var obj = Instantiate(_itemPref, _backpack);
            _allPackItem.Add(obj);
            var script = obj.GetComponent<Item>();
            script.SetItem(data);
            script.SetBackpack(_backpack);
        }
    }
}
