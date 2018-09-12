using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementState
{

    Covered, //被覆盖
    Uncovered, //未覆盖
    Marked //标记
}

public enum ElementType
{
    SingleCovered, //单
    DoubleCovered, //双
    CantCovered //不能翻动
}

public enum ElementContent
{
    Number, //数字
    Trap, //陷阱
    Tool, //工具
    Gold, //金币
    Enemy, //敌人
    Door, //出口
    BigWall, //石墙
    SmallWall, //土墙
    Exit //关闭
}

public enum ToolType
{
    Hp,
    Armor,
    Sword,
    Map,
    Arrow,
    Key,
    Tnt,
    Hoe,
    Grass
}

public enum GoldType
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven
}

public enum WeaponType
{
    None,
    Arrow,
    Sword
}

public enum EffectType
{
    None,
    SmokeEffect,
    UncoveredEffect,
    GoldEffect
}
