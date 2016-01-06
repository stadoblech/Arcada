using UnityEngine;
using System.Collections;
using System.IO;

public class SaveHandler {

    public static string savePath;
    public static string saveFileName = "data.ar";
    static string savedDifficulty;

    public static void saveGame(int levelId)
    {
        savePath = Application.dataPath + "/" + saveFileName;
        using (BinaryWriter writer = new BinaryWriter(File.Open(savePath, FileMode.Create)))
        {
            writer.Write(levelId);
            writer.Write(Difficulty.difficultyModifier.ToString());
        }
    }

    public static int getSavedLevel()
    {
        savePath = Application.dataPath + "/" + saveFileName;

        int savedLevelId;

        if (File.Exists(savePath))
        {

            using (BinaryReader reader = new BinaryReader(File.Open(savePath, FileMode.Open)))
            {
                savedLevelId = reader.ReadInt32();
                savedDifficulty = reader.ReadString();
                return savedLevelId;
            }
        }
        else
        {
            return GameLogic.getActualLevelId() + 1;
        }
    }

    public static GameDifficulty getSavedDifficulty()
    {
        switch(savedDifficulty)
        {
            case "Easy":
                {
                    return GameDifficulty.Easy;
                }
            case "Medium":
                {
                    return GameDifficulty.Medium;
                }
            case "Hard":
                {
                    return GameDifficulty.Hard;
                }
        }

        return GameDifficulty.Default;
    }
}
