using GD.Events;
using GD.ScriptableTypes;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private List<PickupData> pickups;

    [SerializeField]
    private ListPickupDataVariable listPickupDataVariable;

    // do something when a player picks up a collectable
    public void HandlePickup(PickupData pickupData)
    {
        //we can store to a simple list...
        pickups.Add(pickupData);

        //or we can store to a SO list that is serialized on game exit
        listPickupDataVariable.Add(pickupData);

        //print a message
        Debug.Log(pickupData);
    }
}