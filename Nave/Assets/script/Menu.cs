using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string labelButton;
    public string sceneLoad;
    public float positionY;
    public float positonX;
    private void Start()
    {
       
    }
    private void OnGUI()
    {
        const float buttonWidth = 84;
        const float buttonHeight = 60;
        if (GUI.Button(new Rect((Screen.width / this.positonX) - (buttonWidth / 2), (2 * Screen.height / this.positionY) - (buttonWidth / 2), buttonWidth, buttonHeight), this.labelButton))
        {
            SceneManager.LoadScene(this.sceneLoad);
            // Application.LoadLevel("MainScene");
        }
       
    }
}
