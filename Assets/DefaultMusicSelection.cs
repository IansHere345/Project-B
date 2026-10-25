using UnityEngine;

public class DefaultMusicSelection : MonoBehaviour
{
    private static bool initialized = false;
    void Awake()
    {
        if (!initialized)
        {
            PlayerPrefs.SetInt("MusicMuted", 0);
            PlayerPrefs.Save();
            initialized = true;
            // This ensures that ehnever the game is started, the music will be set to on until manually turned off.
        }

    }
}
