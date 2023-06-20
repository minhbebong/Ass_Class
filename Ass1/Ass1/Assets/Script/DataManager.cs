using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    public Color color;
    public float speed;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();

    }

    [System.Serializable]
    class SaveData
    {
        public Color color;
        public float speed;
    }

    public void writeData()
    {
        SaveData data = new SaveData();
        data.color = color;
        data.speed = speed;
        string json = JsonUtility.ToJson(data); 
        File.WriteAllText(Application.persistentDataPath + "/savefile.json",json);
        Debug.Log("Application.persistentDataPath: " + Application.persistentDataPath);

    }
    
    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            color = data.color;
            speed = data.speed;
        }
    }

    
}
