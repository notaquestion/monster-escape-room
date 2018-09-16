using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public SteamVR_LaserPointer LeftLaser;
    public SteamVR_LaserPointer RightLaser;

    public Text UI_Pointing_Text;

    bool subscribed = false;

    List<GameObject> PointingAt = new List<GameObject>();

    

    private SteamVR_Controller.Device LeftController
    {
        get
        {
            //Debug.Log(GameObject.Find("Hand1").GetComponent<Valve.VR.InteractionSystem.Hand>());
            return GameObject.Find("Hand1").GetComponent<Valve.VR.InteractionSystem.Hand>().controller;
        }
    }

    

    // Use this for initialization
    void Start () {
        GameManager.Self.PC = this;

	}



    // Update is called once per frame
    void Update () {

        while (PointingAt.Remove(null)) 

        if(PointingAt.Count > 0)
        {
            UI_Pointing_Text.text = PointingAt[0].name;
        }

        if (LeftController == null)
            return;

        LeftController.hairTriggerDelta = 0.1f;

        //Debug.Log(LeftController.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger));

        if(LeftController.GetHairTriggerDown())
        {

            foreach(GameObject g in PointingAt)
            {
                GrabbableObject grab = g.GetComponent<GrabbableObject>();
                InteractableObject inte = g.GetComponent<InteractableObject>();

                if (grab != null)
                {
                    grab.InteractWith();
                }
                else if (inte != null)
                {
                    inte.InteractWith();
                }
            }
        }
        else if (LeftController.GetHairTriggerUp())
        {

        }
	}

    void OnPointerEnteredAThing(PointerEventArgs e)
    {
        PointingAt.Add(e.target.gameObject);

        GrabbableObject grab = e.target.gameObject.GetComponent<GrabbableObject>();
        InteractableObject inte = e.target.gameObject.GetComponent<InteractableObject>();

        if (grab != null)
        {
            grab.ObjectSelected();
        }
        else if (inte != null)
        {
            inte.ObjectSelected();
        }
    }

    void OnPointerExitedThing(PointerEventArgs e)
    {
        PointingAt.Remove(e.target.gameObject);


        GrabbableObject grab = e.target.gameObject.GetComponent<GrabbableObject>();
        InteractableObject inte = e.target.gameObject.GetComponent<InteractableObject>();

        if (grab != null)
        {
            grab.ObjectDeselected();
        }
        else if (inte != null)
        {
            inte.ObjectDeselected();
        }
    }
}
