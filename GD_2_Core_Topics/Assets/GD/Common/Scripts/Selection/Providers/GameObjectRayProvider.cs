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

        // Implement this OnDrawGizmos if you want to draw gizmos that are also pickable and always drawn
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(currentRay);
        }
    }
}