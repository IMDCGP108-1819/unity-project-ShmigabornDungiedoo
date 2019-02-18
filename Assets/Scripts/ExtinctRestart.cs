using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtinctRestart : MonoBehaviour {
    //Load next scene
	void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
