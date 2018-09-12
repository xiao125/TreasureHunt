using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//使用道具脚本
public class ToolElement : DoubleCoveredElement {

    public ToolType toolType;

    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContent.Tool;
    }

    public override void OnUncovered()
    {
        GetTool(); //获取道具
        base.OnUncovered();
    }

    private void GetTool()
    {
        switch (toolType)
        {
            case ToolType.Hp:
                break;
            case ToolType.Armor:
                break;
            case ToolType.Sword:
                break;
            case ToolType.Map:
                break;

        }
    }

    public override void ConfirmSprite()
    {
        LoadSprite(GameManager.Instance.toolSprites[(int)toolType]);
    }

}
