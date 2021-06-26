using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public string labelButton;
    public float positionY;
    public float positonX;
    private void OnGUI()
    {
        const float buttonWidth = 84;
        const float buttonHeight = 60;
        if (GUI.Button(new Rect((Screen.width / this.positonX) - (buttonWidth / 2), (2 * Screen.height / this.positionY) - (buttonWidth / 2), buttonWidth, buttonHeight), this.labelButton))
        {
            Application.Quit();
            // Application.LoadLevel("MainScene");
        }

    }
}
