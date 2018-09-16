using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInTimer : MonoBehaviour {
    public float timer=0;
    public Text myText;
    public float red = 0;



	// Use this for initialization
	void Start () {
        Color startColor = new Color(0, 0, 0);
        myText.color = startColor;
	}
	
	// Update is called once per frame
	void Update () {

        red += .005f;
        Color myColor = new Color(red, red, red);
        myText.color = myColor;
        timer += Time.deltaTime;
        if (red == 255f)
        {
            if (timer > 3)
            {
                Color whiteColor = new Color(255f, 255f, 255f);
                myText.color = myColor;
            }
        }
	}
}
