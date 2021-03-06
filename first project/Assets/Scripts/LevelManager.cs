﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public float autoloadnext;
    public bool first = false;
    void Start()
    {
        if (first)
        {
            Invoke("LoadNextLevel", autoloadnext);
        }
       
    }
    public void LoadLevel(string name){
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
