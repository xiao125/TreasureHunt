using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//不可翻开基类脚本
public class CantCoveredElement : BaseElement
{
    public override void Awake()
    {
        base.Awake();
        elementType = ElementType.CantCovered;
        elementState = ElementState.Uncovered;
    }

}
