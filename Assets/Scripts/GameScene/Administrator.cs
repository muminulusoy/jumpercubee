using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Administrator : MonoBehaviour
{
    public Text scor;
    public static float scoreNumber=0;
    void Update()
    {
        scor.text = scoreNumber.ToString();
    }
}
