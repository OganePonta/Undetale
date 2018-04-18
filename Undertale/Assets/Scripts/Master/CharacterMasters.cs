using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu]
public class CharacterMasters : ScriptableObject
{
    public List<CharacterMaster> masters;
    public CharacterMaster dummyMaster;

    public static readonly string MasterPath = "Master/CharacterMasters";

    public CharacterMaster SearchMaster(string charaID)
    {
        var master = masters.FirstOrDefault(m => m.name == charaID) as CharacterMaster;
        if (master == null)
            master = dummyMaster;

        return master;
    }
}
