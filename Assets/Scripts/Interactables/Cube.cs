using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Interactable
{
    protected override void Interact()
    {
        //Do Stuff in here
        Debug.Log(gameObject.name);
    }
}
