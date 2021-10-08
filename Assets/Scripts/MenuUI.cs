using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public Button btnStart;
    public InputField playerName;
    public Text scoreText;
    public GameObject uiContainer;
    private TrabalhaArquivo classeArquivo;
    
    // Start is called before the first frame update
    void Start()
    {
        classeArquivo = GameObject.Find("GameObject").GetComponent<TrabalhaArquivo>();
        classeArquivo.LeArquivo();        
        //scoreText.text = "Best Score : " + StorePlayerData.Instance.storedPlayerName + " : " + StorePlayerData.Instance.highestScorePlayer;
    }    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Best Score : " + StorePlayerData.Instance.storedPlayerName + " : " + StorePlayerData.Instance.highestScorePlayer;
        btnStart.onClick.AddListener(StartGame);
    }
    public void StartGame() 
    {
        StorePlayerData.Instance.playerName = playerName.text;
        //Debug.Log("oaisdoiasdjasjd");
        uiContainer.SetActive(false);
        SceneManager.LoadScene("Assets/Scenes/main.unity");                
    }
}
