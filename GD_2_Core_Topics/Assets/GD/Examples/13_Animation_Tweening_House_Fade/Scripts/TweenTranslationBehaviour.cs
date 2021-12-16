using UnityEngine;

/// <summary>
/// Demonstrates LeanTween on translation and alpha on a game object
/// Note:
///  - Object MUST be set to TRANSPARENT in its MATERIAL for the alpha to take effect
/// </summary>
/// <see cref="https://www.youtube.com/watch?v=Ll3yujn9GVQ&t=202s"/>
/// <see cref="https://assetstore.unity.com/packages/tools/animation/leantween-3595"/>
/// <seealso cref="https://easings.net/"/>
public class TweenTranslationBehaviour : MonoBehaviour
{
    [SerializeField]
    public Transform targetPosition;

    [SerializeField]
    public float transitionTimeSecs = 1;

    [SerializeField]
    private LeanTweenType translationEaseType = LeanTweenType.linear;

    [SerializeField]
    private LeanTweenType alphaEaseType = LeanTweenType.linear;

    // Start is called before the first frame update
    private void Start()
    {
        LeanTween.alpha(gameObject, 0, transitionTimeSecs).setEase(alphaEaseType);
        LeanTween.move(gameObject, targetPosition.position, transitionTimeSecs).setEase(translationEaseType);
    }
}