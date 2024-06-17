using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{    

    [SerializeField] SceneController scenes;
    [SerializeField] GameController game;

    public void ResetButton() {
        scenes.ResetActiveScene();
    }

    public void CloseGameButton() {
        game.CloseGame();
    }

    public void TeslaButton () {
        scenes.LoadTeslaScene();
    }

}
