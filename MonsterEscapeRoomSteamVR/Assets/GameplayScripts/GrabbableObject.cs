using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GrabbableObject : MonoBehaviour {
    //puts glow around object when selected
    public bool breaksOnImpact;
    public bool grabbableObject;
    public string nameOfCombinableObject;
    public List<GameObject> objectsToSpawn = new List<GameObject>();
    private bool hasBeenPickedUp;

    public UnityEvent Interact;

    public Outline outline;
    public void Awake()
    {
       outline = gameObject.AddComponent<Outline>();
    }
    private void Start()
    {
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
    public void InteractWith()
    {
        Interact.Invoke();
        hasBeenPickedUp = true;
        
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (breaksOnImpact == true && hasBeenPickedUp == true)
        {
            foreach (GameObject g in objectsToSpawn)
            {
                Instantiate(g, g.transform.position, Quaternion.identity);
            }
            if (gameObject.name != "ExplodingChair")
                Destroy(gameObject);
            else
                SendMessage("Explode", transform);

         }
    }
}
