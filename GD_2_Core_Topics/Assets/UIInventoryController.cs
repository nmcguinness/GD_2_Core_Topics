using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventoryController : MonoBehaviour
{
    [SerializeField]
    private LeanTweenType fadeInTweenType;

    [SerializeField]
    private LeanTweenType fadeOutTweenType;

    public void FadeIn()
    {
        LeanTween.moveX(gameObject, 256, 1).setEase(fadeInTweenType);
        LeanTween.alpha(gameObject, 1, 4);
    }

    public void FadeOut()
    {
        //slide out
        LeanTween.moveX(gameObject, -512, 1).setEase(fadeOutTweenType);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}