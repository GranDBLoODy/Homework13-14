using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour {
  

    public void Settings()
    {

    }

    public void GamePlay()
    {
        SceneManager.LoadScene("MainMenu");
    }
    

}
