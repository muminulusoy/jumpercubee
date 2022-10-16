using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
  
    void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        Debug.Log(Time.timeScale);
    }

}
