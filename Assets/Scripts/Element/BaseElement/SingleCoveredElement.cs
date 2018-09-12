using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
//可以翻开一次的元素的基类
public class SingleCoveredElement : BaseElement
{
    public override void Awake()
    {
        base.Awake(); //先执行基类的Awake()方法
        elementType = ElementType.SingleCovered; //保存自己的类型
        elementState = ElementState.Covered; //当前状态

        //随机加载一张泥土的图片
        LoadSprite(GameManager.Instance.coverTileSprites[Random.Range(0, GameManager.Instance.coverTileSprites.Length)]);
    }

    public override void OnPlayerStand()
    {
        switch (elementState)
        {
            case ElementState.Covered:
                UncoveredElement();
                break;
            case ElementState.Uncovered:
                return;
            case ElementState.Marked: //
                RemoveFlag(); //
                break;
        }
    }

    public override void OnRightMouseButton()
    {
        switch (elementState)
        {
            case ElementState.Covered:
                AddFlag(); //标记为陷阱
                break;
            case ElementState.Uncovered:
                return;
            case ElementState.Marked: 
                RemoveFlag(); //解除标记
                break;
        }
    }


    /// <summary>
    /// 翻开当前元素的操作
    /// </summary>
    public virtual void UncoveredElement()
    {
        if (elementState == ElementState.Uncovered) return;
        UncoveredElementSingle();
        OnUncovered();

    }

    /// <summary>
    ///仅仅翻开当前元素自身
    /// </summary>
    public virtual void UncoveredElementSingle() { }

    /// <summary>
    /// 翻开自身后要做的操作
    /// </summary>
    public virtual void OnUncovered() { }

    /// <summary>
    /// 将元素标记为陷阱
    /// </summary>
    public void AddFlag()
    {
        elementState = ElementState.Marked;
        GameObject flag = Instantiate(GameManager.Instance.flagElement, transform);
        flag.name = "FlagElement";
        flag.transform.DOLocalMoveY(0, 0.1f); //移动动画
        Instantiate(GameManager.Instance.smokeEffect, transform);
        
    }

    /// <summary>
    /// 解除元素的标记
    /// </summary>
    public void RemoveFlag()
    {
        Transform flag = transform.Find("FlagElement");
        if (flag !=null)
        {
            elementState = ElementState.Covered;
            flag.DOLocalMoveY(0.15f, 0.1f).onComplete += () =>
              {
                  Destroy(flag.gameObject);
              };
        }
        
    }
}
