using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStart : MonoBehaviour {

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        if (musicManager)
        {
            float volume = PlayerPrefsManager.GetMasterVolume();
            musicManager.SetVolume(volume);
        }
        else
        {
            Debug.LogError("NO music manager in thestart screen, cfn't set volume");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
