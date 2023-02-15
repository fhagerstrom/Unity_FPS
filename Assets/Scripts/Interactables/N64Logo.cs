using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N64Logo : Interactable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Design interactable behaviour here.
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }
}
