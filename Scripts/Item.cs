using UnityEngine;
using UnityEngine.UI;
using static ItemData;

public class Item : MonoBehaviour
{
    [SerializeField] 
    private ItemData _data;
    [SerializeField]
    private Text _nameDebug;
    private ItemType _type;
    public delegate GameObject MenuEvent(Item script);
    public static event MenuEvent GetHandPos;
    public static event MenuEvent GetBodyPos;
    public delegate void SetItemEvent(float attack, float defence);
    public static event SetItemEvent GetHandStat;
    public static event SetItemEvent GetBodyStat;
    public delegate void NullItemEvent();
    public static event NullItemEvent NullHandStat;
    public static event NullItemEvent NullBodyStat;
    public static event NullItemEvent NullHandMenu;
    public static event NullItemEvent NullBodyMenu;
    private bool _equip = false;
    private Transform _backpack;

    public void SetItem(ItemData data)
    {
        _data = data;
        _type = _data.GetType();
        _nameDebug.text = _data.GetName();
    }

    public void SetBackpack(Transform backpack)
    {
        _backpack = backpack;
    }

    public void ClickOnItem()
    {
        if (_equip)
        {
            ReturnToBackpack();
        }
        else
        {
            SetEquip();
            _equip = true;
        }
    }

    private void SetEquip()
    {
        GameObject parent;
        switch (_type)
        {
            case ItemType.body:
                parent = GetBodyPos?.Invoke(this);
                GetBodyStat?.Invoke(_data.GetAttack(), _data.GetDefence());
                transform.SetParent(parent.transform);
                transform.position = parent.transform.position;
                break;
            case ItemType.hand:
                parent = GetHandPos?.Invoke(this);
                GetHandStat?.Invoke(_data.GetAttack(), _data.GetDefence());
                transform.SetParent(parent.transform);
                transform.position = parent.transform.position;
                break;
        }
    }

    public void ReturnToBackpack()
    {
        _equip = false;
        transform.SetParent(_backpack);
        switch (_type)
        {
            case ItemType.body:
                NullBodyMenu?.Invoke();
                NullBodyStat?.Invoke();
                break;
            case ItemType.hand:
                NullHandMenu?.Invoke();
                NullHandStat?.Invoke();
                break;
        }
    }
}
