using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	                                           //simple script to change games (1 and 2)
	// Update is called once per frame
	void Update () {
		
	}
    public void Game1()
    {
        SceneManager.LoadScene(1);
    }
    public void Game2()
    {
        SceneManager.LoadScene(2);
    }
    
}
