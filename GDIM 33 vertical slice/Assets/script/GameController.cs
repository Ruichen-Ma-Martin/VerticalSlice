using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance { get; private set; }
    public bullet bullet;
    public enemyattack enemyattack;
    public player player;
    private void Awake()
    {
        instance = this;
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
    }
    private void Update()
    {
        if (player == null)
        {
            RestartCurrentScene();
        }
    }

    public void RestartCurrentScene()
    {
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
