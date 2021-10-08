using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorePlayerData : MonoBehaviour
{
    public static StorePlayerData Instance;
    public string playerName;
    public string storedPlayerName;
    public int highestScorePlayer;
    public string scoreText;
        
    private void Awake()
    {
        if (Instance != null) 
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }
}
