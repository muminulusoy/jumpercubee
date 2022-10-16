using UnityEngine;
using UnityEngine.SceneManagement;

public class SetGame : MonoBehaviour
{
    private void Update()
    {
        Click();
    }

    public void Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene (sceneName:"GameScene");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }
}
