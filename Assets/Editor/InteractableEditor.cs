using UnityEditor;

[CustomEditor(typeof(Interactable), true)]
public class InteractableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactable interactable = (Interactable)target;
        base.OnInspectorGUI();

        // We are using events, add component.
        if(interactable.useEvents) 
        {
            if(interactable.GetComponent<InteractionEvent>() == null)
                interactable.gameObject.AddComponent<InteractionEvent>();
        }

        else
        {
            // We don't use events, remove component.
            if (interactable.GetComponent<InteractionEvent>() != null)
                DestroyImmediate(interactable.GetComponent<InteractionEvent>());

        }
    }
}
