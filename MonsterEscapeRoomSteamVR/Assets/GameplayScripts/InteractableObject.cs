using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour {

    //puts different glow that grabbableObject when selected
   
    public UnityEvent Interact;

    public Outline outline;
    private void Awake()
    {
        outline = gameObject.AddComponent<Outline>();
    }

    private void Start()
    {
        outline.enabled = false; 
    }

    public void ObjectSelected()
    {
        outline.enabled = true;
        outline.OutlineMode = Outline.Mode.OutlineVisible;
        outline.OutlineColor = Color.blue;
        outline.OutlineWidth = 9.8f;
       
    }
    public void ObjectDeselected()
    {
        outline.enabled = false;
        outline.OutlineMode = Outline.Mode.OutlineHidden;
        
    }
    public void Reset()
    {
        
        outline.OutlineMode = Outline.Mode.OutlineHidden;
        outline.OutlineColor = Color.blue;
        outline.OutlineWidth = 9.8f;
    }

    public void InteractWith()
    {
        Interact.Invoke();
    }

}


   