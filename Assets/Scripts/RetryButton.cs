﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public Button retryButton;
    // Use this for initialization
    void Start()
    {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
        retryButton.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
		SceneManager.LoadScene (GameManager.levelName);
    }
}