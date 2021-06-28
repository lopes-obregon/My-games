using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string labelButton;
    public string sceneLoad;
    public float positionY;
    public float positonX;
    public float buttonWidth = 300;
    public float buttonHeight = 100;

    private GUISkin newSkin;
    private void Start()
    {
        newSkin = Resources.Load("MenuLabel") as GUISkin;
    }
    private void OnGUI()
    {
        GUI.skin = newSkin;
        if (GUI.Button(new Rect((Screen.width / this.positonX) - (buttonWidth / 2), (2 * Screen.height / this.positionY) - (buttonWidth / 2), buttonWidth, buttonHeight), this.labelButton))
        {
            SceneManager.LoadScene(this.sceneLoad);
            // Application.LoadLevel("MainScene");
        }
       
    }
}
