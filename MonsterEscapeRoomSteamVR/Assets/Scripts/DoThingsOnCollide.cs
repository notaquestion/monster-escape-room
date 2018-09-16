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
                Instantiate(InstantiateThis, transform.position, transform.rotation);

                Destroy(other.gameObject);
                Destroy(transform.parent.gameObject);
            }
        }
    }
}
