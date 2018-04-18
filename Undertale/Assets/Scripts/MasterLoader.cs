using UnityEngine;

public static class MasterLoader
{
    public static CharacterMaster LoadCharacterMaster(string charaID)
    {
        string masterPath = CharacterMaster.MasterPathHeader + "/" + charaID;

        return Resources.Load(masterPath) as CharacterMaster;
    }
}
