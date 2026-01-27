using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainTitleScript : MonoBehaviour
{
    public Canvas upgradeCanvas;
    public Canvas titleScreen;

    void Start()
    {
        upgradeCanvas.enabled = false;
    } 

    public void playGame()
    {
        SceneManager.LoadScene("PTScene");
    }

    public void openMetaUpgrades()
    {
        titleScreen.enabled = false;
        upgradeCanvas.enabled = true;
    }

    public void closeMetaUpgrades()
    {
        upgradeCanvas.enabled = false;
        titleScreen.enabled = true;
    }
}