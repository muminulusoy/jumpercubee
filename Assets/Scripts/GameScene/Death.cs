using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public static Action TriggerPointDeath;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TriggerPointDeath.Invoke();
        SceneManager.LoadScene (sceneName:"ScoreScene");
    }
    
}
