﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    float GameTime;

    public static GameManager Self;

    public PlayerController PC; //Player Controlelr
    public WatchScript Watch;
    public NarrativeEventManager NarrativeManager;

	// Use this for initialization
	void Awake () {
        if (Self != null)
        {
            Debug.LogWarning("NOT THE ONLY GAME MANGAGER");
            return;
        }

        Self = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void LoadNextScene()
    {
        LoadNextScene();
    }
}
