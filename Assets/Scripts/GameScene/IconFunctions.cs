using UnityEngine;
using UnityEngine.SceneManagement;

public class IconFunctions : MonoBehaviour
{
    private bool game = false;
    public void LoadMenu()
    {
        SceneManager.LoadScene (sceneName:"MainMenu");
    }

    public void GamePause()
    {
        if(game == false)
        {
            PauseGame();
            game = true;
        }
        else
        {
            ResumeGame();
            game = false;
        }
    }
    void PauseGame ()
    {
        Time.timeScale = 0;
    }
    void ResumeGame ()
    {
        Time.timeScale = 1;
    }
}
