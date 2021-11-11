using GD.Events;
using UnityEngine;

namespace GD.Controllers
{
    public class DoorToggleEventTrigger : MonoBehaviour
    {
        public string targetTag;
        public GameEvent OnDoorToggle;

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
}