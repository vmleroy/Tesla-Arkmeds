using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{    
    public void TelaButton () {
        SceneManager.LoadScene("Tela");
        Debug.Log("Loading Tela scene...");
    }
    public void TeslaButton () {
        SceneManager.LoadScene("Tesla");
        Debug.Log("Loading Tesla scene...");
    }
}
