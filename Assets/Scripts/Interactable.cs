using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Pop-up message when looking at interactable object
    public string promptMessage;

    // Will be called by the player
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        // EMPTY
        // Template function for overriding subclasses
    }
}
