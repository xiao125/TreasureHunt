using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//出口
public class ExitElement : CantCoveredElement
{
    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.Exit;
        ClearShadow();
        name = "Exit";
        LoadSprite(GameManager.Instance.exitSprite);
    }

}
