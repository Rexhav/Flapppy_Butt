using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager instance;
    public GameObject _gameOverCanvas;

    private void Awake(){
        if (instance == null){
            instance = this;
        }
        Time.timeScale = 1f;
    }

    public void GameOver(){
        Time.timeScale = 0;
        _gameOverCanvas.SetActive(true);

        
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
    public void Start(){
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
  
}
