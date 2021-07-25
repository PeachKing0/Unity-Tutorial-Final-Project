using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public InputField input;
    public string PlayerName;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        PlayerName = input.text;
        SceneManager.LoadScene(1);
    }

    [System.Serializable]
    class SaveData
    {
        public string PlayerUsername;
    }

    public void SaveUsername()
    {
        SaveData data = new SaveData
        {
            PlayerUsername = PlayerName
        };

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(Application.persistentDataPath + "/savefile.json");
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerName = data.PlayerUsername;
        }
    }
}
