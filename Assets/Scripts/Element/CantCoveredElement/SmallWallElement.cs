using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//小墙脚本
public class SmallWallElement : CantCoveredElement {

    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.SmallWall;
        ClearShadow();
        LoadSprite(GameManager.Instance.smallwallSprites[Random.Range(0, GameManager.Instance.smallwallSprites.Length)]);
    }
}
