using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//陷阱脚本
public class TrapElement : SingleCoveredElement
{
    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.Trap; //当前是陷阱标识
    }

    public override void UncoveredElementSingle()
    {
        if (elementState == ElementState.Uncovered) return;
        RemoveFlag();
        elementState = ElementState.Uncovered;
        ClearShadow();
        //TODO 计算并显示自身数字

        //TODO 显示泥土翻开的特效
        Instantiate(GameManager.Instance.uncoveredEffect, transform);
        //显示陷阱图片
        LoadSprite(GameManager.Instance.trapSprites[Random.Range(0, GameManager.Instance.trapSprites.Length)]);
    }

    public override void OnUncovered()
    {
        //TODO 翻开所有雷
        GameManager.Instance.DisplayAllTraps();
    }

    

}
