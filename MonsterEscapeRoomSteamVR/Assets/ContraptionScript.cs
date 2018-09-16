using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ContraptionScript : MonoBehaviour {

    public UnityEvent BatteryAdded;
    public UnityEvent DuckTapeAdded;
    public UnityEvent PennyAdded;

    public UnityEvent EveryithingAdded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.name)
        {
            case "Duct_Tape(Clone)":
                DuckTapeAdded.Invoke();
                Destroy(collision.gameObject);
                break;

            case "Battery_Coils(Clone)":
                BatteryAdded.Invoke();
                Destroy(collision.gameObject);
                break;
            case "Penny":
                PennyAdded.Invoke();
                Destroy(collision.gameObject);

                break;

            default:
                Debug.Log("Contraption collided with " + collision.gameObject.name);
                break;
        }
    }


}
