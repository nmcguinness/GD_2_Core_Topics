using UnityEngine;

namespace GD.Selection
{
    public class TargetSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        [Tooltip("Set prefab object used for target highlighting")]
        private GameObject targetSelectionPrefab;

        [SerializeField]
        private LayerMask targetGroundLayerMask;

        [SerializeField]
        [Tooltip("Vertical offset on target highlight above ground layer")]
        [Range(0.01f, 10)]
        private float targetOffset = 0.01f;

        [SerializeField]
        [Tooltip("Sets scale factor on object dimension dependent target prefab")]
        [Range(1, 10)]
        private float scaleFactor = 5;

        private GameObject currentTargetInstance;

        //TODO - Make serialise field?
        private int rayCastDepth = 10;

        public void Awake()
        {
            currentTargetInstance = Instantiate(targetSelectionPrefab,
                Vector3.zero, Quaternion.Euler(0, 0, 0));

            currentTargetInstance.SetActive(false);
        }

        public void OnSelect(Transform selection)
        {
            if (currentTargetInstance != null)
            {
                RaycastHit hitInfo;
                if (Physics.Raycast(selection.position, -selection.up,
                    out hitInfo, rayCastDepth, targetGroundLayerMask))
                {
                    currentTargetInstance.transform.position = selection.position - new Vector3(0, hitInfo.distance - targetOffset, 0);
                    float mag = selection.GetComponent<Collider>().bounds.size.magnitude / scaleFactor;
                    currentTargetInstance.transform.localScale = new Vector3(mag, mag, mag);
                    currentTargetInstance.SetActive(true);
                }
            }
        }

        public void OnDeselect(Transform selection)
        {
            currentTargetInstance.SetActive(false);
        }
    }
}