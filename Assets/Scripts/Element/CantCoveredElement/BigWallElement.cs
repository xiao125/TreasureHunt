using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//不可翻开里面的大墙脚本
public class BigWallElement : CantCoveredElement {

    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.BigWall;
        LoadSprite(GameManager.Instance.bigwallSprites[Random.Range(0, GameManager.Instance.bigwallSprites.Length)]);
    }
}
