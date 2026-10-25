using UnityEngine;
using TMPro;

public class gameEndedManager : MonoBehaviour
{
    public static string winner;

    void Start()
    {
        TextMeshProUGUI winnerText = GameObject.Find("WinnerText").GetComponent<TextMeshProUGUI>();
        if (winnerText != null)
        {
            winnerText.text = winner;
        }
    }
}


