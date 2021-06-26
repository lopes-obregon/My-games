using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private string labelButton;
    private string sceneLoad;
    private float positionY;
    private float positonX ;
    private GUISkin newSin;
    private void Start()
    {
        newSin = (GUISkin)Resources.Load("MenuLabel");
    }
    private void OnGUI()
    {
        this.labelButton = "Retry!";
        this.sceneLoad = "MainScene";
        this.positionY = 2.5f;
        this.positonX = 2;

        const float buttonWidth = 84;
        const float buttonHeight = 60;
        
        if (GUI.Button(new Rect((Screen.width / this.positonX) - (buttonWidth / 2), (2 * Screen.height / this.positionY) - (buttonWidth / 2), buttonWidth, buttonHeight), this.labelButton))
        {
            SceneManager.LoadScene(this.sceneLoad);
            Time.timeScale = 1;
            // Application.LoadLevel("MainScene");
        }
        this.labelButton = "Menu!";
        this.sceneLoad = "MenuScene";
        this.positonX = 2;
        this.positionY =3.5f;
        if (GUI.Button(new Rect((Screen.width / this.positonX) - (buttonWidth / 2), (2 * Screen.height / this.positionY) - (buttonWidth / 2), buttonWidth, buttonHeight), this.labelButton))
        {
            SceneManager.LoadScene(this.sceneLoad);
            // Application.LoadLevel("MainScene");
        }
        GUI.skin = newSin;
        this.labelButton = "Game Over!";
        this.positionY = 5.5f;
        this.positonX = 5.5f;
        Rect position = new Rect((Screen.width / this.positonX) - (buttonWidth / 2), (2 * Screen.height / this.positionY) - (buttonWidth / 2), 500, 500);
        GUI.Label(position, this.labelButton);

    }
}
