using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//金币脚本
public class GoldElement : DoubleCoveredElement
{
    public GoldType goldType;

    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.Gold;
    }

    public override void OnUncovered()
    {
        Transform goldEffect = transform.Find("GoldEffect");
        if (goldEffect !=null)
        {
            GetGold();
        }

        base.OnUncovered();
    }

    private void GetGold()
    {

    }

    public override void ConfirmSprite()
    {
        Transform goldEffect = transform.Find("GoldEffect");
        if (goldEffect == null)
        {

        }
        LoadSprite(GameManager.Instance.goldSprites[(int)goldType]);
    }

}
