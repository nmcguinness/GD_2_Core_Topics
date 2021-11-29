using GD.Events;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private List<PickupData> pickups;

    // do something when a player picks up a collectable
    public void HandlePickup(PickupData pickupData)
    {
        pickups.Add(pickupData);
        Debug.Log(pickupData);
    }
}