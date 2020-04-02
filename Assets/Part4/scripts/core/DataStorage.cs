using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    public GameInfo gameInfo;

    private void Start()
    {
        Load();  
    }

    private void OnApplicationQuit()
    {
        Save();  
    }

    [ContextMenu("Save")]
    public void Save()
    {
        PlayerPrefs.SetString(Keys.SAVE_KEY, JsonUtility.ToJson(gameInfo));
        Debug.LogFormat("<color=green>{0}</color>", JsonUtility.ToJson(gameInfo)); 
    }


    [ContextMenu("Load")]
    public void Load()
    {
        gameInfo = JsonUtility.FromJson<GameInfo>(PlayerPrefs.GetString(Keys.SAVE_KEY)); 
    }
}

public static class Keys
{
    public const string SAVE_KEY = "Save"; 
    public const string LOAD_KEY = "Load"; 
}
