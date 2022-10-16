using TMPro;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI finalScore;
    [SerializeField]private TextMeshProUGUI highScore;
    
    private float currentScore=0;
    private float maxScore=0;
    
    private void Awake()
    {
        currentScore = PlayerPrefs.GetFloat("score");
        maxScore = PlayerPrefs.GetFloat("highScore");
        
        if (maxScore < currentScore)
        {
            PlayerPrefs.SetFloat("highScore",currentScore);
            maxScore = PlayerPrefs.GetFloat("highScore");
        }
        
        finalScore.text = currentScore.ToString();
        highScore.text = maxScore.ToString();
    }

}
