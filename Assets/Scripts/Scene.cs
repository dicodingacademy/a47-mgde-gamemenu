using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

    // pindah scene ke menu
    public void MenuScene() {
        SceneManager.LoadScene("Menu");
        Debug.Log("Menu Scene");
    }

    // pindah scene ke loading
    public void LoadingScene() {
        SceneManager.LoadScene("Loading");
        Debug.Log("Loading Scene");
    }

    // keluar dari game
    public void KeluarScene() {
        Application.Quit();
        Debug.Log("Keluar Game");
    }
}
