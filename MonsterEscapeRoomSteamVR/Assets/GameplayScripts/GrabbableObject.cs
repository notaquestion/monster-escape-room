using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour {
    //puts glow around object when selected
    public bool breaksOnImpact;
    public bool grabbableObject;

    public Outline outline;
    private void Start()
    {
       outline = gameObject.AddComponent<Outline>();
        outline.enabled = false;
    }

    public void ObjectSelected ()
    {
        outline.enabled = true;
        outline.OutlineMode = Outline.Mode.OutlineVisible;
        outline.OutlineColor = Color.yellow;
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
        outline.OutlineColor = Color.yellow;
        outline.OutlineWidth = 9.8f;
    }
    public void Awake()
    {

    }


}
