using UnityEngine;

namespace GD.Selection
{
    public class SoundSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        private AudioClip selectedAudioClip;

        private Transform currentSelectedTransform = null;

        public void OnDeselect(Transform transform)
        {
            //no sound on deselect
        }

        public void OnSelect(Transform transform)
        {
            if (currentSelectedTransform != null
                && currentSelectedTransform != transform)
            {
                AudioSource.PlayClipAtPoint(selectedAudioClip,
                    transform.position);
            }

            //store what we newly pointed at
            currentSelectedTransform = transform;
        }
    }
}