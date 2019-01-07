using UnityEngine;

public class LevelEnd : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D collision)
    {//loads the complete level animation
        gameManager.CompleteLevelUI();
        
    }

}
