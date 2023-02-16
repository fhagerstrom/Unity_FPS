using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triforce : Interactable
{
    // Temporary door opener
    [SerializeField]
    private GameObject door;
    private bool doorOpen;


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
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("Opened", doorOpen);

        // Debug.Log("Interacted with " + gameObject.name);
    }
}
