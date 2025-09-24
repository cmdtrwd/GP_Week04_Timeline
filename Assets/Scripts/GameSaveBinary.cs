using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class GameSaveBinary
{
    public static void SaveData(GameSaveManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        // Define the location where the file will be saved
        string path = Application.persistentDataPath + "/gameData.pom";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(gameManager);

        formatter.Serialize(stream, data);
        
        //Always close the stream once the data is saved
        stream.Close();
    }

    public static GameData LoadData()
    {
        string path = Application.persistentDataPath + "/gameData.pom";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            
            //Always close the stream once the data is saved
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
