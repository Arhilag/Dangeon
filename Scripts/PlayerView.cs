using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Sprite _playerTexture;
    [SerializeField] private float _attack;
    [SerializeField] private float _defence;
    //[SerializeField] private ItemData
    private ItemStat _bodyStat = new ItemStat();
    private ItemStat _handStat = new ItemStat();
    [SerializeField] private List<string> _items;

    private void Start()
    {
        Item.GetHandStat += SetHand;
        Item.GetBodyStat += SetBody;
        Item.NullHandStat += NullHand;
        Item.NullBodyStat += NullBody;
    }

    private void OnDestroy()
    {
        Item.GetHandStat -= SetHand;
        Item.GetBodyStat -= SetBody;
        Item.NullHandStat -= NullHand;
        Item.NullBodyStat -= NullBody;
    }

    public float GetAttack()
    {
        var attack = _attack + _bodyStat.GetAttack() + _handStat.GetAttack();
        return attack;
    }

    public float GetDeffence()
    {
        var defence = _defence + _bodyStat.GetDefence() + _handStat.GetDefence();
        return defence;
    }

    public void SetBody(float attack, float defence)
    {
        _bodyStat.Set(attack, defence);
    }

    public void NullBody()
    {
        _bodyStat.NullifyStat();
    }

    public void SetHand(float attack, float defence)
    {
        _handStat.Set(attack, defence);
    }

    public void NullHand()
    {
        _handStat.NullifyStat();
    }

    public void SetItem(string name)
    {
        _items.Add(name);
    }

    public string GetItem(int item)
    {
        return _items[item];
    }

    public int GetItemCount()
    {
        return _items.Count;
    }
}
