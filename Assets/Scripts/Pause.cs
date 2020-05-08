using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public string TitleScreen;
    public gameObject pauseMenu;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape)){
        if(isPaused){
          Resume();
        }else{
          isPaused = true;
          pauseMenu.SetActive(true);
          Time.timeScale = 0f;
        }
      }
    }

    public void Resume(){
      isPaused = false;
      pauseMenu.SetActive(false);
      Time.timeScale = 1f;
    }

    public void MainMenu(){
      SceneManager.LoadScene(TitleScreen);
    }
}
