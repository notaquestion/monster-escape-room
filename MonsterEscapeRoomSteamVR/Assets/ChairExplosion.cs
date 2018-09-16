using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairExplosion : MonoBehaviour
{

    private void Start()
    {
        //Explode(transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Explode(transform);
        }
    }

    public void Explode(Transform t)
    {
        int originalChildCount = t.childCount;
        for (int i = 0; i < originalChildCount; ++i)
        {
            t.GetChild(i).gameObject.AddComponent<Rigidbody>().AddForce(new Vector3(Random.value, Random.value, Random.value) * 200f);
            t.GetChild(i).gameObject.AddComponent<BoxCollider>();


            //t.GetChild(0).SetParent(null);
            Destroy(t.GetChild(i).gameObject, 3);

            //Explode(t);
        }
        transform.DetachChildren();
        GetComponent<Collider>().enabled = false;
    }

}
