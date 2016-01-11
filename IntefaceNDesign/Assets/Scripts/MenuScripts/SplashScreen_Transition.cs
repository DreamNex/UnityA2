using UnityEngine;
using System.Collections;

public class SplashScreen_Transition : MonoBehaviour {

    float timeToChange = 5;

	// Use this for initialization
	void Start () {

         
	
	}
	
	// Update is called once per frame
	void Update () {

        timeToChange -= Time.deltaTime;

        if(timeToChange <= 0)
        {
            //Change the scene to menu scene
            Application.LoadLevel("MenuScene");
        }
	
	}

    public void ChangeToMenu()
    {
        Application.LoadLevel("MenuScene");
    }
}
