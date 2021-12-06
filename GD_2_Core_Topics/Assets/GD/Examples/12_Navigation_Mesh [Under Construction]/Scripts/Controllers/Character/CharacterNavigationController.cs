using GD.ScriptableTypes;
using GD.Selection;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

/// <summary>
/// Supports click to select and click to set waypoint on a mav mesh
/// </summary>
/// <see cref="https://www.youtube.com/watch?v=CHV1ymlw-P8"/>
/// <seealso cref="https://www.youtube.com/watch?v=FkLJ45Pt-mY&t=158s"/>

namespace ARVR.Controllers
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class CharacterNavigationController : MonoBehaviour
    {
        [Header("Selection & Waypoint")]
        [SerializeField]
        [Tooltip("Set the game object used to indicate that the character using this controller is currently selected.")]
        private GameObject selectionPrefab;

        [SerializeField]
        [Tooltip("Set the game object used to indicate a waypoint for the character using this controller for navigation.")]
        private GameObject waypointPrefab;

        [SerializeField]
        [Tooltip("Used by the waypoint when the character is moving. Can be simple empty object.")]
        private GameObject sceneAnchor;

        [Header("Selected Object Buffer")]
        [SerializeField]
        [Tooltip("A scriptable object which holds a reference to the currently selected character")]
        private GameObjectVariable currentlySelectedGameObject;

        private Animator animator;
        private NavMeshAgent navMeshAgent;
        private IRayProvider rayProvider;
        private ISelector selector;
        private RaycastHit hitInfo;
        private bool isSelected;

        private void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            rayProvider = GetComponent<IRayProvider>();
            selector = GetComponent<ISelector>();
            animator = GetComponent<Animator>();
        }

        public void OnSelectWaypoint(InputAction.CallbackContext context)
        {
            if (isSelected)
            {
                ClickDestination();
            }
        }

        public void OnSelectPlayer(InputAction.CallbackContext context)
        {
            if (currentlySelectedGameObject.Value != null && currentlySelectedGameObject.Value != gameObject)
            {
                currentlySelectedGameObject.Value = null;
                SetSelected(false);
            }

            SetSelected(true);
            currentlySelectedGameObject.Value = gameObject;
        }

        private void Update()
        {
            if (Vector3.Distance(navMeshAgent.destination, transform.position) <= navMeshAgent.stoppingDistance)
            {
                ClearWaypoint();
                animator.SetBool("IsWalking", false);
            }
        }

        #region Actions -  Set/Clear destination and waypoint

        private void SetDestination(Vector3 target)
        {
            navMeshAgent.SetDestination(target);
        }

        private void ClickDestination()
        {
            selector.Check(rayProvider.CreateRay());
            if (selector.GetSelection() != null)
            {
                hitInfo = selector.GetHitInfo();
                SetDestination(hitInfo.point);
                SetWaypoint();
                SetSelected(false);
                animator.SetBool("IsWalking", true);
            }
        }

        private void SetWaypoint()
        {
            waypointPrefab.SetActive(true);
            waypointPrefab.transform.SetParent(sceneAnchor.transform);
            waypointPrefab.transform.position = navMeshAgent.destination;
        }

        private void ClearWaypoint()
        {
            waypointPrefab.SetActive(false);
            waypointPrefab.transform.SetParent(transform);
        }

        public void SetSelected(bool isSelected)
        {
            this.isSelected = isSelected;
            selectionPrefab.SetActive(isSelected);
        }

        #endregion Actions -  Set/Clear destination and waypoint

        #region OLD INPUT - Selection

        //private void OnMouseDown()
        //{
        //    if (currentlySelectedGameObject.Value != null && currentlySelectedGameObject.Value != gameObject)
        //    {
        //        currentlySelectedGameObject.Value = null;
        //        SetSelected(false);
        //    }

        //    SetSelected(true);
        //    currentlySelectedGameObject.Value = gameObject;
        //}

        ////private void Update()
        //{
        //    if (Input.GetMouseButtonDown(1) && isSelected)
        //    {
        //        ClickDestination();
        //    }

        //    if (Vector3.Distance(navMeshAgent.destination, transform.position) <= navMeshAgent.stoppingDistance)
        //    {
        //        ClearWaypoint();
        //        animator.SetBool("IsWalking", false);
        //    }
        //}

        #endregion OLD INPUT - Selection
    }
}