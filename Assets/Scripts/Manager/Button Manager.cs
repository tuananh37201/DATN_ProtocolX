using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SettingButton()
    {

    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackToMenuButton()
    {
        SceneManager.LoadScene(0);
    } 
}
