﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainControl : MonoBehaviour
{
    public void btnCross_Click()
    {
        SceneManager.LoadScene("Cross");
    }

    public void btnSequence_Click()
    {
        SceneManager.LoadScene("Sequence");
    }

    public void btnSliding_Click()
    {
        SceneManager.LoadScene("Sliding");
    }
}