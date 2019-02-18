using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D col)
    {//calls the two restart methods if triggers the restarter object
        gameManager.RestartLevelUI();
        gameManager.EndGame();
    }




}
