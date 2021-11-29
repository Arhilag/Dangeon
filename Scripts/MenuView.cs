using UnityEngine;

public class MenuView : MonoBehaviour
{
    [SerializeField]
    private GameObject _bodyCase;
    private Item _bodyData;
    [SerializeField]
    private GameObject _handCase;
    private Item _handData;

    private void Start()
    {
        Item.GetBodyPos += GetBodyPos;
        Item.GetHandPos += GetHandPos;
        Item.NullBodyMenu += NullBody;
        Item.NullHandMenu += NullHand;
    }

    private void OnDestroy()
    {
        Item.GetBodyPos -= GetBodyPos;
        Item.GetHandPos -= GetHandPos;
        Item.NullBodyMenu -= NullBody;
        Item.NullHandMenu -= NullHand;
    }

    private GameObject GetBodyPos(Item script)
    {
        if (_bodyData != null)
        {
            _bodyData.ReturnToBackpack();
        }
        _bodyData = script;
        return _bodyCase;
    }

    private void NullBody()
    {
        _bodyData = null;
    }

    private GameObject GetHandPos(Item script)
    {
        if (_handData != null)
        {
            _handData.ReturnToBackpack();
        }
        _handData = script;
        return _handCase;
    }

    private void NullHand()
    {
        _handData = null;
    }
}
