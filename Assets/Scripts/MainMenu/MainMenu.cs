using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SettingButton()
    {

    }
    public void CreditsButton()
    {

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
