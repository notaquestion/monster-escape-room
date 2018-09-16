using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

    //puts different glow that grabbableObject when selected
   
    public void ObjectSelected()
    {

        var outline = gameObject.AddComponent<Outline>();
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineColor = Color.green;
        outline.OutlineWidth = 9.8f;
    }
    public void ObjectDeselected()
    {
        var outline = gameObject.AddComponent<Outline>();
        outline.OutlineMode = Outline.Mode.OutlineHidden;
    }
    public void Reset()
    {
        var outline = gameObject.AddComponent<Outline>();
        outline.OutlineMode = Outline.Mode.OutlineHidden;
        outline.OutlineColor = Color.yellow;
        outline.OutlineWidth = 9.8f;
    }
    public void Awake()
    {
        
    }

}
