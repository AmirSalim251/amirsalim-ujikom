using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    public void changeScene(){
        SceneManager.LoadScene(sceneName);
    }

    public void exitGame(){
        Application.Quit();
        
    }
}
