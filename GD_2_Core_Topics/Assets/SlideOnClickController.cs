using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideOnClickController : MonoBehaviour
{
    private RectTransform rectTransform;
    private bool notYetIn = true;

    [SerializeField]
    private LeanTweenType fadeInTweenType;

    [SerializeField]
    private LeanTweenType fadeOutTweenType;

    public void FadeOut()
    {
        //slide out
        LeanTween.moveX(gameObject, -128, 1).setEase(fadeOutTweenType);
    }

    // Update is called once per frame
    private void Update()
    {
        //if (Input.GetKeyDown("M") && notYetIn)
        //{
        //    LeanTween.moveX(gameObject, 128, 1).setEase(LeanTweenType.easeInBounce);
        //    notYetIn = false;
        //}

        if (Time.realtimeSinceStartup > 2 && notYetIn)
        {
            //slide in
            LeanTween.moveX(gameObject, 128, 1).setEase(fadeInTweenType);
            notYetIn = false;
        }
        //else if (Time.realtimeSinceStartup > 4)
        //{
        //    //slide out
        //    LeanTween.moveX(gameObject, -128, 1).setEase(LeanTweenType.easeInBounce);
        //}
    }
}