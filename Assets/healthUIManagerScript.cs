using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class healthUIManagerScript : MonoBehaviour
{
    public TextMeshProUGUI Player1HealthText;
    public TextMeshProUGUI Player2HealthText;
    public Health Player1Health;
    public Health Player2Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
    }
        
    void UpdateHealth()
    {
        if (Player1HealthText != null)
        {
            if (Player1Health != null)
            {
                Player1HealthText.text = "Blue: " + Player1Health.CurrentHealth;
            }
            else
            {
                Player1HealthText.text = "Blue: 0";
            }
        }

        if (Player2HealthText != null)
        {
            if (Player2Health != null)
            {
                Player2HealthText.text = "Orange: " + Player2Health.CurrentHealth;
            }
            else
            {
                Player2HealthText.text = "Orange: 0";
            }
        }
    }
    //Update Health is like this because once the game object is destroyed, the Ui no longer updates.
    //This ensures once the object is gone, the UI can still display 0 health.
}
