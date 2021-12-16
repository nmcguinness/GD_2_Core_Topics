using System.Collections;
using UnityEngine;

public class OnMouseEnterButtonAnimation : MonoBehaviour
{
    [SerializeField]
    private string animationTriggerID = "Wobble";

    [SerializeField]
    [Range(0, 2)]
    private float activationCooldownSeconds = 0.25f;

    private Animator animator;
    private int hashAnimationTrigger;
    private WaitForSeconds cooldownWait;
    private bool inCooldown;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        hashAnimationTrigger = Animator.StringToHash(animationTriggerID.Trim());
        cooldownWait = new WaitForSeconds(activationCooldownSeconds);
    }

    private void OnMouseEnter()
    {
        if (!inCooldown)
        {
            animator.SetTrigger(hashAnimationTrigger);
            StartCoroutine(ActivationCooldown());
        }
    }

    private IEnumerator ActivationCooldown()
    {
        inCooldown = true;
        yield return cooldownWait;
        inCooldown = false;
    }
}