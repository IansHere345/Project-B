using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public TMP_Text player1StatusText;
    public TMP_Text player2StatusText;
    public string SampleSceneName = "SampleScene";

    private bool player1Ready;
    private bool player2Ready;
    private bool isLoadingScene;

    void Start()
    {
        UpdateStatusText();
    }

    void Update()
    {
        if (!player1Ready && Player1PressedReadyKey())
        {
            player1Ready = true;
            UpdateStatusText();
        }

        if (!player2Ready && Player2PressedReadyKey())
        {
            player2Ready = true;
            UpdateStatusText();
        }

        if (player1Ready && player2Ready && !isLoadingScene)
        {
            isLoadingScene = true;
            SceneManager.LoadScene(SampleSceneName);
        }
    }

    bool Player1PressedReadyKey() //Player 1 inputs
    {
        return Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.D);
    }

    bool Player2PressedReadyKey() //Player 2 inputs
    {
        return Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow);
    }
    //This makes it so both players need to have input before the game starts

    void UpdateStatusText()
    {
        if (player1StatusText != null)
        {
            player1StatusText.text = player1Ready ? "Ready!" : "Not Ready";
        }

        if (player2StatusText != null)
        {
            player2StatusText.text = player2Ready ? "Ready!" : "Not Ready";
        }
    }
}

