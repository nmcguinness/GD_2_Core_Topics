using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace GD.Events
{
    public enum PickupType : sbyte
    {
        Health, Ammo, Money, Mana
    }

    public struct PickupData
    {
        private int value;
        private PickupType type;
    }

    [CreateAssetMenu(fileName = "PickupEvent", menuName = "Scriptable Objects/Events/Pickup")]
    public class PickupEvent : BaseGameEvent<PickupData>
    {
        public override void Raise(PickupData parameters)
        {
            base.Raise(parameters);
        }
    }

    [Serializable]
    public class UnityPickupEvent : UnityEvent<PickupData>
    {
    }

    public class PickupGameEventListener : BaseGameEventListener<PickupData, PickupEvent, UnityPickupEvent>
    {
    }
}