using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Transform pauseMenu;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(pauseMenu.gameObject.activeSelf){
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else {
                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void ResumeGame(){
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void SairJogo(){
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
