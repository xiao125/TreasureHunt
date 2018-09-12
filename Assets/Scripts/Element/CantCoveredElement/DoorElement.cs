using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//门脚本
public class DoorElement : CantCoveredElement {

    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.Door;
        LoadSprite(GameManager.Instance.doorSprite);
    }
}
