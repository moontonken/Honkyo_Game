﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class returnto : MonoBehaviour
{
    private void Update()
    {
        LoadScene();

    }
    public void LoadScene()

    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Menu Inicial");
        }


    }
    }

