using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public SteamVR_LaserPointer LeftLaser;
    public SteamVR_LaserPointer RightLaser;

    public Text UI_Pointing_Text;

    bool subscribed = false;

    List<string> PointingAt = new List<string>();

    // Use this for initialization
    void Start () {
        GameManager.Self.PC = this;

        UI_Pointing_Text = GameObject.Find("PointingAt").GetComponent<Text>();
        UI_Pointing_Text.text = "Blah";
	}



    // Update is called once per frame
    void Update () {
        //if(LeftLaser.PointerIn != null)
        {
            //Subscribe();
            subscribed = true;
        }
		
        if(PointingAt.Count > 0)
        {
            UI_Pointing_Text.text = PointingAt[0];
        }
        
        //SteamVR_ControllerManager
	}

    void OnPointerEnteredAThing(PointerEventArgs e)
    {
        PointingAt.Add(e.target.gameObject.name);

        GrabbableObject grab = e.target.gameObject.GetComponent<GrabbableObject>();
        InteractableObject inte = e.target.gameObject.GetComponent<InteractableObject>();

        if (grab != null)
        {
           
        }
        else if (inte != null)
        {

        }
    }

    void OnPointerExitedThing(PointerEventArgs e)
    {
        PointingAt.Remove(e.target.gameObject.name);
    }
}
