using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TrabalhaArquivo : MonoBehaviour
{
    private string filePath;
    private string[] arqivoLido;
    // Start is called before the first frame update
    
    
    public void EscreveArquivo(int m_Points)
    {
        filePath = Path.Combine(Application.persistentDataPath, "playerData.txt");
        Debug.Log(StorePlayerData.Instance.highestScorePlayer);
        if (StorePlayerData.Instance.highestScorePlayer < m_Points)
        {
            StorePlayerData.Instance.highestScorePlayer = m_Points;
            File.WriteAllText(filePath, StorePlayerData.Instance.playerName + " : " + StorePlayerData.Instance.highestScorePlayer, System.Text.Encoding.UTF8);
            StorePlayerData.Instance.scoreText = "Best Score : " + StorePlayerData.Instance.playerName + " : " + StorePlayerData.Instance.highestScorePlayer;
            Debug.Log("SOBRESCREVEU");
        }
        else
        {
            StorePlayerData.Instance.scoreText = "Best Score : " + StorePlayerData.Instance.storedPlayerName + " : " + StorePlayerData.Instance.highestScorePlayer;
            Debug.Log("MANTEVE");
        }

    }

    public void LeArquivo()
    {
        filePath = Path.Combine(Application.persistentDataPath, "playerData.txt");
        int numberPosition;
        if (File.Exists(filePath))
        {
            Debug.Log("LEU");
            arqivoLido = File.ReadAllLines(filePath);
            StorePlayerData.Instance.scoreText = arqivoLido[0];
            StorePlayerData.Instance.storedPlayerName = arqivoLido[0].Substring(0, arqivoLido[0].IndexOf(":"));
            numberPosition = arqivoLido[0].IndexOf(":");
            numberPosition++;
            //Debug.Log(arqivoLido[0].Substring(numberPosition));
            StorePlayerData.Instance.highestScorePlayer = int.Parse(arqivoLido[0].Substring(numberPosition));
        }
        else
        {
            File.CreateText(filePath);
            //Debug.Log("Criou o Arquivo");
            StorePlayerData.Instance.scoreText = "Best Score : " + StorePlayerData.Instance.playerName + " : " + StorePlayerData.Instance.highestScorePlayer;
        }

    }
    private void Start()
    {
        //filePath = Path.Combine(Application.persistentDataPath, "playerData.txt");
    }

}
