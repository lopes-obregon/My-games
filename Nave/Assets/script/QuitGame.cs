using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public string labelButton;
    public float positionY;
    public float positonX;
    public float buttonWidth = 500;
    public float buttonHeight = 600;

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
            Application.Quit();
            // Application.LoadLevel("MainScene");
        }

    }
}
