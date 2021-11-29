using GD.Events;
using UnityEngine;

public class PlayerPickupBehaviour : MonoBehaviour
{
    [SerializeField]
    private LayerMask pickupTargetLayer;

    [SerializeField]
    private PickupEvent pickupEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (pickupTargetLayer.OnLayer(other.gameObject))
        {
            var pickup = other.gameObject.GetComponent<PickupBehaviour>();
            if (pickup != null)
            {
                pickupEvent.Raise(pickup.PickupData);
                Destroy(other.gameObject);
            }
        }
    }
}