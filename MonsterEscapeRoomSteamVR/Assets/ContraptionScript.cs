using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ContraptionScript : MonoBehaviour {

    public UnityEvent BatteryAdded;
    public UnityEvent DuckTapeAdded;
    public UnityEvent PennyAdded;

    public UnityEvent EveryithingAdded;

    bool Battery;
    bool Duck;
    bool Penny;

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
                Duck = true;
                break;

            case "Battery_Coils(Clone)":
                BatteryAdded.Invoke();
                Destroy(collision.gameObject);
                Battery = true;
                break;
            case "Penny":
                PennyAdded.Invoke();
                Destroy(collision.gameObject);
                Penny = true;
                break;

            default:
                Debug.Log("Contraption collided with " + collision.gameObject.name);
                break;
        }

        if(Duck && Battery && Penny)
        {
            EveryithingAdded.Invoke();
        }
    }


}
