using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;  //creating variable to control the gameover panel

    private void Start()
    {
        gameOverPanel.SetActive(false);//game overpanel wont be shown util Player object collides
    }
    
    public void GameOver()//method will be called in PlayerCollision.cs and the game over panel will be shown! 
    {
        gameOverPanel.SetActive(true);  
    }

    //now we will provide functionality to both the buttons!
    public void Restart() //to reload game when rsestart button clicked!
    {
        SceneManager.LoadScene("Game");  //when restart button clicked it will reload the scene!
    }

    //Quit game method:

    public void QuitGame()
    {
        Application.Quit();
    }
}
