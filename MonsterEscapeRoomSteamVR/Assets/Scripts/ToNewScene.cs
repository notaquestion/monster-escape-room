using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNewScene : MonoBehaviour {
    public string nameOfNewScene;


    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("toNextScene"))
        {
            Debug.Log("to the next one, governor!");
            SceneManager.LoadScene(nameOfNewScene);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
