using System;
using TMPro;
using UnityEngine;

public class Administrator : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI score;
    
    private float scoreNumber=0;

    private void Awake()
    {
        Groundds.TriggerPoint += UpdatePoint;
    }

    private void UpdatePoint()
    {
        scoreNumber += 1;
        score.text = scoreNumber.ToString();
    }
}
