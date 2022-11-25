using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class tween : MonoBehaviour
{
    private DOTween _doTween;

    private void Awake()
    {
        _doTween = new DOTween();
    }
}
