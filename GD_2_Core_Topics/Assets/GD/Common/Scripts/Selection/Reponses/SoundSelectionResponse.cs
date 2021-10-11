using UnityEngine;

namespace GD.Selection
{
    public class SoundSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        private AudioClip selectedAudioClip;

        [SerializeField]
        [Range(0, 1)]
        private float selectedVolume = 0.5f;

        private Transform currentSelectedTransform = null;

        public void OnDeselect(Transform transform)
        {
            //no sound on deselect
        }

        public void OnSelect(Transform transform)
        {
            if (currentSelectedTransform != transform)
            {
                AudioSource.PlayClipAtPoint(selectedAudioClip,
                    transform.position, selectedVolume);
            }

            //store what we newly pointed at
            currentSelectedTransform = transform;
        }
    }
}