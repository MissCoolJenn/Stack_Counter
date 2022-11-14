using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Logic : MonoBehaviour
{
    public TextMeshProUGUI StacksCountTMP, AnotherCountTMP;
    int _itemCount, _stackCount, _itemsLeft;

    public void StringToInt(string q)
    {
        _itemCount = int.Parse(q);
    }
    public void RecountStacks()
    {
        _stackCount = 0;
        for (int i = 0; true; i++)
        {
            if (_itemCount >= 64)
            {
                _itemCount = _itemCount - 64;
                _stackCount++;
            }
            else if (_itemCount < 64)
            {
                _itemsLeft = _itemCount;
                SetCount();
                break;
            }
        }
    }
    void SetCount()
    {
        StacksCountTMP.text = _stackCount.ToString();
        AnotherCountTMP.text = _itemsLeft.ToString();
    }
}
