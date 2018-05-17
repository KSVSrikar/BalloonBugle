using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInputFrequency : MonoBehaviour {

    public GameObject freq;       //Main input field to toggle visibility
    public GameObject tokill1;    //To remove other 
    public GameObject tokill2;    //inputfields
    public Sprite defaultcursor;   
    public Sprite handcursor;
    public Sprite qmark;          
    public SpriteRenderer rend;   
    private InputField field;
    public Text txterror;           //error display(not in range)
    public TextMesh textdisplay;    //display entered frequency

    // Use this for initialization
    void Start () {
        freq.SetActive(false);                    // make sure input field is invisible at start(before click)
        field = freq.GetComponent<InputField>();  //get input field component from input field gameobject
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnMouseEnter()
    {
        rend.sprite = handcursor;          //toggle handcursor on entering questionmark
    }
    void OnMouseExit()
    {
        rend.sprite = defaultcursor;       //default cursor on leaving questionmark
    }
    void OnMouseDown()
    {
        freq.SetActive(true);              //bring main inputfield and deactivate existing fields on click
        tokill1.SetActive(false);
        tokill2.SetActive(false);
    }
    public void InputCheck()                           //this function is called OnEndEdit in inputfield properties
    {
        if (float.Parse(field.text) < 300 || float.Parse(field.text) > 1500)    //given condition check for frequency range
        {
            field.text = "";                                                    //remove entered invalid number
            textdisplay.text = "";                                              //remove existing displayed frequency(I assumed wrong frequency is entered)
            SpriteRenderer qm = gameObject.GetComponent<SpriteRenderer>();      //put the questionmark back so as to fill it in future
            qm.sprite = qmark;                                                  
            txterror.text = "Frequency OUT OF RANGE(300Hz-1500Hz)";              //error display in redtext
        }
        else
        {
            textdisplay.text = float.Parse(field.text).ToString();               //set input to display if in range
            SpriteRenderer qm = gameObject.GetComponent<SpriteRenderer>();       //remove questionmark
            qm.sprite = null;
            freq.SetActive(false);                                               //remove field from view
        }
    }
    public void Cleartxt()                                                     // called on value change in input field  
    {
        txterror.text = "";                                                    //just to remove error text while taking input again
    }

}
