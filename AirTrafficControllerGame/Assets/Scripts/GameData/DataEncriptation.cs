
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class DataEncriptation 
{
    public static void saveBadges(Badges badges)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.badgesData";
        FileStream stream = new FileStream(path, FileMode.Create);

        DataToSave data = new DataToSave(badges);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static DataToSave loadBadges()
    {
        string path = Application.persistentDataPath + "/save.badgesData";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            DataToSave data = formatter.Deserialize(stream) as DataToSave;
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
