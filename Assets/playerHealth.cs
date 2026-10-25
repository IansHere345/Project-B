using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    public int CurrentHealth => currentHealth;
    public bool Player1;
    public bool Player2;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0f)
        {
            // Handle player death here
            Destroy(gameObject); // Destroy the player object
            if (Player2)
            {
                gameEndedManager.winner = "Blue Wins!";
            }
            else if (Player1)
            {
                gameEndedManager.winner = "Orange Wins!";
            }
            SceneManager.LoadScene("GameEndedScene");
        }
    }
    public void FixedUpdate()
    {
        if (transform.position.y < -30f)
        {
            Destroy(gameObject); // Destroy the player object
            if (Player2)
            {
                gameEndedManager.winner = "Blue Wins!";
            }
            else if (Player1)
            {
                gameEndedManager.winner = "Orange Wins!";
            }
            SceneManager.LoadScene("GameEndedScene");
            //Source Used for transform.position: //Source Used: https://www.youtube.com/watch?v=Mic9ERhr0HA&t=103s
        }
    } 
    public void Heal(int amount)
    {
        currentHealth += amount;
    }
    //Source Used: https://www.geeksforgeeks.org/c-sharp/health-system-in-unity/
}
