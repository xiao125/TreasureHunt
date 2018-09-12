using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//基类
public class BaseElement : MonoBehaviour {

    public int x;
    public int y;
    public ElementState elementState;
    public ElementType elementType;
    public ElementContent elementContent;

    public virtual void Awake()
    {
        x = (int)transform.position.x;
        y = (int)transform.position.y;
        name = "(" + x + "," + y + ")";
    }

    //当鼠标在当前物体的碰撞器上每帧都调用     virtual关键字表示虚方法，可重写此方法
    public virtual void OnMouseOver()
    {
        ////当鼠标移动到物体上 2：鼠标中建
        // Input.GetMouseButtonUp() : 当移动到物体上再移出时，不触发
        if (Input.GetMouseButtonUp(2))
        {
            OnMiddleMouseButton();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            OnLeftMouseButton();
        }
        else if (Input.GetMouseButtonUp(1))
        {
            OnRightMouseButton();
        }
    }

    /// 当角色站立在当前元素上时候执行的操作
    public virtual void OnPlayerStand()
    {

    }

    /// 当玩家左键点击当前元素时候执行的操作
    public virtual void OnLeftMouseButton()
    {
        OnPlayerStand();
        
    }


    /// 当玩家中键点击当前元素时候执行的操作
    public virtual void OnMiddleMouseButton() {

    }

    /// 当玩家右键点击当前元素时候执行的操作
    public virtual void OnRightMouseButton() {

    }

    /// 切换当前元素的图片
    public void LoadSprite(Sprite sprite)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }


    /// <summary>
    /// 去除当前元素的阴影效果
    /// </summary>
    public void ClearShadow()
    {
        Transform shadow = transform.Find("shadow");
        if (shadow !=null)
        {
            Destroy(shadow.gameObject);
        }
    }


    /// <summary>
    /// 将当前元素转化为数字元素并翻开
    /// </summary>
    /// <param name="needEffect">是否需要显示泥土特效</param>
    public void ToNumberElement(bool needEffect)
    {
        GameManager.Instance.mapArray[x, y] = gameObject.AddComponent<NumberElement>();
        ((NumberElement)GameManager.Instance.mapArray[x, y]).needEffect = needEffect;
        ((NumberElement)GameManager.Instance.mapArray[x, y]).UncoveredElement();
        Destroy(this);
    }
}
