﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class QuitButton : MonoBehaviour {
    public Button quitButton;
	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
        quitButton.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void TaskOnClick () {
        Application.Quit();
	}
}
