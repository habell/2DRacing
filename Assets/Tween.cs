using DG.Tweening;
using UnityEngine;

public class Tween : MonoBehaviour
{
    private void Awake()
    {
        DOTween.Init();
        transform.DOMoveX(5, 10, false);
    }

    public void TestTween()
    {
        var pos = transform.position;
        var scale = new Vector3(pos.x, pos.y, pos.z);
        transform.DOScaleX(10, 3);
    }
}