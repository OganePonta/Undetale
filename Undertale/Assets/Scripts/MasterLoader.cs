using UnityEngine;

public static class MasterLoader
{
    private static CharacterMasters _characterMasters = null;

    public static CharacterMaster LoadCharacterMaster(string charaID)
    { 
        if(_characterMasters == null)
        {
            _characterMasters = Resources.Load(CharacterMasters.MasterPath) as CharacterMasters;
        }

        return _characterMasters.SearchMaster(charaID);
    }
}
