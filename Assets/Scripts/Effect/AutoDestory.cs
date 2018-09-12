using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//自动销毁脚本
public class AutoDestory : MonoBehaviour {

    public float delay;

    private void Start()
    {
        Destroy(gameObject, delay);
    }
}
