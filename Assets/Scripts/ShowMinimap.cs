﻿using UnityEngine;
using System.Collections;

public class ShowMinimap : MonoBehaviour
{
    public GameObject minimapCanvas;

	void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            print("Fire2 down");
            minimapCanvas.SetActive(true);
        }
        if (Input.GetButtonUp("Fire2"))
        {
            print("Fire2 up");
            minimapCanvas.SetActive(false);
        }
        //else
        //{
        //    minimapCanvas.SetActive(false);
        //}

    }
}