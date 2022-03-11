﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score1 : MonoBehaviour
{
    Text text;
    public static int coinAmount = 5;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
        if (coinAmount == 0)
        {
            SceneManager.LoadScene("iksan");
        }

    }

}

