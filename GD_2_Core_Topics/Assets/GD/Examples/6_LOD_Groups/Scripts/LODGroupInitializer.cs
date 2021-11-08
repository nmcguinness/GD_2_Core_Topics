using UnityEngine;

namespace GD.LOD
{
    public class LODGroupInitializer : MonoBehaviour
    {
        [SerializeField]
        [Range(0, 5)]
        private float crossFadeAnimationDurationSecs = 1;

        // Start is called before the first frame update
        private void Start()
        {
            LODGroup.crossFadeAnimationDuration = crossFadeAnimationDurationSecs;
        }
    }
}