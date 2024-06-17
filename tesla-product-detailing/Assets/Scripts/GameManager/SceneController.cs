using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ResetActiveScene() {
        Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.name);
    }
    
    public void LoadTeslaScene() {
        SceneManager.LoadScene("Tesla");
        Debug.Log("Loading Tesla scene...");
    }
}
