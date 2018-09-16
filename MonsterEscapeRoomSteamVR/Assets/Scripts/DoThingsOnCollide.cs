using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoThingsOnCollide : MonoBehaviour {

    public string OtherObject;

    public UnityEvent OnCollideWithObject;

    public bool DestoryAndMakePrefab;
    public GameObject InstantiateThis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == OtherObject)
        {
            OnCollideWithObject.Invoke();

            if(DestoryAndMakePrefab)
            {
                if (InstantiateThis == null)
                    return;

                Instantiate(InstantiateThis, transform.position, transform.rotation);

                StealthyDestory(other.gameObject);
                StealthyDestory(transform.parent.gameObject);

                InstantiateThis = null;
                //(other.gameObject);
                //Destroy(transform.parent.gameObject);
            }
        }
    }

    public void StealthyDestory(GameObject target)
    {
        if(target.transform.parent != null && (target.transform.parent.name == "Hand1" || target.transform.parent.name == "Hand2"))
            GetComponentInParent<Valve.VR.InteractionSystem.Hand>().DetachObject(target, false);

        Destroy(target, 0.2f);
    }
}
