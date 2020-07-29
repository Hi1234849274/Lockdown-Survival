using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    private bool isPaused;
    [Header("Keybinding")]
    public KeyCode pauseKey = KeyCode.Escape;
    [Header("References")]
    public GameObject PausePanel;

    void Update() {
        if (Input.GetKeyDown(pauseKey)) {
            if (isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }
    public void Pause() {
        isPaused = true;
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
    }
    public void Resume() {
        isPaused = false;
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }
    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
}