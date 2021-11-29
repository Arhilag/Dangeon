using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewBase : MonoBehaviour
{
    [SerializeField] private ItemView _itemView;
    [SerializeField] private PlayerView _playerView;

    public ItemData[] GetAllItem()
    {
        return _itemView.GetItemData();
    }

    public ItemData GetItemData(string name)
    {
        return _itemView.GetItemData(name);
    }

    public void GetStats()
    {
        Debug.Log(_playerView.GetAttack() + " " + _playerView.GetDeffence());
    }


    public string GetItem(int item)
    {
        return _playerView.GetItem(item);
    }

    public void SetItem(string name)
    {
        _playerView.SetItem(name);
    }

    public int GetItemCount()
    {
        return _playerView.GetItemCount();
    }
}
