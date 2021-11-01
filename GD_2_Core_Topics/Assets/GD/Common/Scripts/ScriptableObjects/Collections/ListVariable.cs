using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GD.ScriptableTypes
{
    //  [CreateAssetMenu(fileName = "ListVariable", menuName = "Scriptable Objects/Collections/List")]
    public class ListVariable<T> : NumberVariable<T>
    {
        [SerializeField]
        private List<T> list;

        //Clear, Count, Add, Sort
    }

    //ListWeaponPropertiesVariable

    //WeaponProperty struct (name, lethality, type, range)

    [CreateAssetMenu(fileName = "ListVariable",
                menuName = "Scriptable Objects/Collections/List/String")]
    public class ListStringVariable : ListVariable<string>
    {
    }
}