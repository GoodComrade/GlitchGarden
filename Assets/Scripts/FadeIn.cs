using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public float fadeInTime;

    private Image FadePanel;
    private Color currentColour = Color.black;

	// Use this for initialization
	void Start () {
        FadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChange = Time.deltaTime / fadeInTime;
            currentColour.a -= alphaChange;
            FadePanel.color = currentColour;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
