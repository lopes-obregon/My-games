using UnityEngine;

public class LabelGameName : MonoBehaviour
{
    public string labelButton;
    public float positionY;
    public float positonX;
    public float buttonWidth;
    public float buttonHeight;

    private GUISkin newSkin;
    private void Start()
    {
        newSkin = Resources.Load("MenuLabel") as GUISkin;        
    }
    private void OnGUI()
    {
        GUI.skin = newSkin;
       

        GUI.Label(new Rect((Screen.width / this.positonX) - (buttonWidth / 2), (2 * Screen.height / this.positionY) - (buttonWidth / 2), buttonWidth, buttonHeight), this.labelButton);

    }
}
