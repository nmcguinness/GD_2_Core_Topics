using UnityEngine;

namespace GD.Selection
{
    public class GameObjectRayProvider : MonoBehaviour, IRayProvider
    {
        [SerializeField]
        private GameObject rayOrigin;

        private Ray currentRay;

        public Ray CreateRay()
        {
            currentRay = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);
            return currentRay;
        }
    }
}