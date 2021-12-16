using UnityEngine;

/// <summary>
/// Fades a target object out/in based on trigger enter/exit using LeanTween library
/// Note:
///  - Cheat -> Object MUST be set to TRANSPARENT in its MATERIAL for the alpha to take effect
/// </summary>
/// <see cref="https://www.youtube.com/watch?v=Ll3yujn9GVQ&t=202s"/>
/// <seealso cref="https://assetstore.unity.com/packages/tools/animation/leantween-3595"/>
/// <seealso cref="https://easings.net/"/>
public class FadeOnTriggerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToFade;

    [SerializeField]
    private LayerMask triggerObjectLayerMask;

    [SerializeField]
    [Min(0.1f)]
    private float fadeTimeSecs = 1;

    [SerializeField]
    private LeanTweenType easeType = LeanTweenType.linear;

    private void OnTriggerEnter(Collider collider)
    {
        if (IsValid(collider))
        {
            //fade to transparent using the ease curve
            LeanTween.alpha(objectToFade, 0, fadeTimeSecs);//.setEase(easeType);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (IsValid(collider))
        {
            //fade to opaque using the ease curve
            LeanTween.alpha(objectToFade, 1, fadeTimeSecs).setEase(easeType);
        }
    }

    private bool IsValid(Collider collider)
    {
        //an extension method added to LayerMask - see LayerMaskExtensions.cs
        return triggerObjectLayerMask.OnLayer(collider.gameObject);
    }
}