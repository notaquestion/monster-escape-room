﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GrabbableObject : MonoBehaviour {
    //puts glow around object when selected
    public bool breaksOnImpact;
    public bool grabbableObject;
    public string nameOfCombinableObject;
    public List<GameObject> objectsToSpawn = new List<GameObject>();

    int TimesHit = 0;

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


        GameObject.Find("TelekensisOrigin").GetComponent<Telekenisis>().AssignTarget(gameObject);
        
        
    }

    public void StealthyDestory()
    {
        if (transform.parent != null && (transform.parent.name == "Hand1" || transform.parent.name == "Hand2"))
            GetComponentInParent<Valve.VR.InteractionSystem.Hand>().DetachObject(gameObject, false) ;
        Destroy(gameObject, 0.2f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (breaksOnImpact == true)
        {
            ++TimesHit;

            if (TimesHit < 3)
                return;

            foreach (GameObject g in objectsToSpawn)
            {
                Instantiate(g, gameObject.transform.position + new Vector3(0, 1, 0) , Quaternion.identity);
                //Debug.Log("Cubes spawn at " + g.transform.position);
            }
            if (gameObject.name != "ExplodingChair")
                Destroy(gameObject, 0.1f);
            else
                SendMessage("Explode", transform);

         }
    }
}
