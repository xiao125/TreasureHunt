using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//显示数字脚本
public class NumberElement : SingleCoveredElement
{

    public bool needEffect = true;

    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.Number;
    }

    public override void OnMiddleMouseButton() //点击中键
    {
        GameManager.Instance.UncoveredAdjacentElements(x, y);
    }

    /// <summary>
    /// 仅仅翻开当前元素自身
    /// </summary>
    public override void UncoveredElementSingle()
    {
        if (elementState == ElementState.Uncovered) return;
        RemoveFlag();
        elementState = ElementState.Uncovered;
        ClearShadow();
        //TODO 显示泥土翻开的特效
        if (needEffect == true)
        {
            Instantiate(GameManager.Instance.uncoveredEffect, transform);
        }
        //TODO 计算并显示自身数字
        LoadSprite(GameManager.Instance.numberSprites[GameManager.Instance.CountAdjacentTraps(x, y)]);
    }

    /// <summary>
    /// 翻开自身后要做的操作
    /// </summary>
    public override void OnUncovered()
    {
        //泛洪算法翻开周边元素
        GameManager.Instance.FloodFillElement(x, y, new bool[GameManager.Instance.w, GameManager.Instance.h]);
    }

    

}
