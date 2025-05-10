using UnityEngine;

public class ShowInstructions : MonoBehaviour
{
    public GameObject instructionsPanel;

    public void ToggleInstructions()
    {
        instructionsPanel.SetActive(!instructionsPanel.activeSelf);
    }
}
