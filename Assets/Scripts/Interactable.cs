using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{

    // Add / Remove InteractionEvent on game object
    public bool useEvents;

    [SerializeField]
    // Pop-up message when looking at interactable object
    public string promptMessage;

    // Will be called by the player
    public void BaseInteract()
    {
        if(useEvents)
            GetComponent<InteractionEvent>().onInteraction.Invoke(); // Should NEVER be null since we use an editor script.
        // Consider using enum / switch cases for handling the interact functions.
        Interact();
    }
    protected virtual void Interact()
    {
        // EMPTY
        // Template function for overriding subclasses
    }
}
