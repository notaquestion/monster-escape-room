using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioSources : MonoBehaviour {
    public List<AudioSource> AudioSources;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySources(int i)
    {
        if (AudioSources.Count > i)
            AudioSources[i].Play();
    }
}
