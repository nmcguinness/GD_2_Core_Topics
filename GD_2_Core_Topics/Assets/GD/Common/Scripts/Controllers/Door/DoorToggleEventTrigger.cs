using GD.Events;
using UnityEngine;

//public enum TriggerEntity : sbyte
//{
//    Player, NONPC, Robot
//}

public class DoorToggleEventTrigger : MonoBehaviour
{
    public string targetTag;
    public GameEvent OnDoorToggle;

    //  public TriggerEntity entityTag;

    private void Awake()
    {
        targetTag = targetTag.Trim();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
        {
            OnDoorToggle?.Raise();
        }
    }
}