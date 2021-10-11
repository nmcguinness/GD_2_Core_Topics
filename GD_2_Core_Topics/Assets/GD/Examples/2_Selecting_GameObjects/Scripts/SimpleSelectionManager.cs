using UnityEngine;

//SOLID
//Single Responsibility Principle

public class SimpleSelectionManager : MonoBehaviour
{
    [SerializeField]
    private string selectableTag = "Selectable";

    [SerializeField]
    private Color selectedColor = Color.green;

    private Transform selection;
    private Ray ray;

    private void Awake()
    {
        selectableTag = selectableTag.Trim();
    }

    // Update is called once per frame
    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo = new RaycastHit();
        if (Physics.Raycast(ray, out hitInfo))
        {
            var currentSelection = hitInfo.transform;
            if (currentSelection.CompareTag(selectableTag))
            {
                selection = currentSelection;
                selection.GetComponent<Renderer>().material.color = selectedColor;
            }
        }
    }
}