using System;

[Serializable]
public class ItemStat
{
    private float _attack = 0;
    private float _defence = 0;

    public void Set(float attack, float defence)
    {
        _attack = attack;
        _defence = defence;
    }

    public void NullifyStat()
    {
        _attack = 0;
        _defence = 0;
    }

    public float GetAttack()
    {
        return _attack;
    }

    public float GetDefence()
    {
        return _defence;
    }
}
