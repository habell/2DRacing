using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class tween : MonoBehaviour
{
    private void Awake()
    {
        DOTween.Init();
        transform.DOMoveX(10, 10, false);
    }

    public void TestTween()
    {
        var pos = transform.position;
        var scale = new Vector3(pos.x, pos.y, pos.z);
        transform.DOScaleX(10, 3);
    }
}
