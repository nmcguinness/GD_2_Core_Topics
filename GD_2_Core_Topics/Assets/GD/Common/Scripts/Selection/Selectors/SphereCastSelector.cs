using UnityEngine;

namespace GD.Selection
{
    public class SphereCastSelector : MonoBehaviour, ISelector
    {
        public void Check(Ray ray)
        {
            throw new System.NotImplementedException();
        }

        public RaycastHit GetHitInfo()
        {
            throw new System.NotImplementedException();
        }

        public Transform GetSelection()
        {
            throw new System.NotImplementedException();
        }
    }
}