using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextandAudioControl : MonoBehaviour {

    public Text text;                 //to display appropriate reason for stopped sound
    public AudioSource clip;           //buglesound
    public Sprite defaultcursor;       
    public Sprite handcursor;
    public SpriteRenderer rend;


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnMouseEnter()                    //toggle handcursor on entering hotspots
    {
        rend.sprite = handcursor;
    }

    void OnMouseDown()                      //appropriate text at respective hotspots
    {                                       //also remove sound
        if (gameObject.tag == "HS1")
        {
            text.text = "When a finger is pressed against the balloon covering the mouth of the bottle, there is no vibration and no sound";
            clip.enabled = false;
        }
        if (gameObject.tag == "HS2")
        {
            text.text = "When the cut end of the bottle is closed, no air can be expelled and hence no sound is generated";
            clip.enabled = false;
        }
        if (gameObject.tag == "HS3")
        {
            text.text = "When the balloon stem is pressed, no air can be blown and there is no sound";
            clip.enabled = false;
        }
        if (gameObject.tag == "HS4")
        {
            text.text = "When the balloon mouth is pressed, no air flows and there is no vibration or sound";
            clip.enabled = false;
        }

    }


    void OnMouseExit()                    //toggle defaultcursor on leaving hotspot
    {
        rend.sprite = defaultcursor;
        text.text = "";                    //also remove existing text for new text to followup
        clip.enabled = true;               // enable sound
    }
}
