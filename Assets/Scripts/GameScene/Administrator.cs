using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;

public class Administrator : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI score;
    
    private float scoreNumber=0;
    private bool fileCheck;
    
    private void Awake()
    {
        Groundds.TriggerPoint += UpdatePoint;
        Death.TriggerPointDeath += SaveScore;
    }

    private void UpdatePoint()
    {
        scoreNumber += 1;
        score.text = scoreNumber.ToString();
    }

    private void SaveScore()
    {
        PlayerPrefs.SetFloat("score",scoreNumber);
        
    }
    
}
