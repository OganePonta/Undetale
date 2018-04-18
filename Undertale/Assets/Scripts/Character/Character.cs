using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private string charaID;

    private string Name { set; get; }
    private string TalkMessage { get; set; }

    private void Awake()
    {
        LoadCharacterMaster(charaID);
    }

    public void Talk()
    {
        Debug.Log(Name + " : " + TalkMessage);
    }

    private void LoadCharacterMaster(string charaID)
    {
        var character = MasterLoader.LoadCharacterMaster(charaID);
        SetData(character.charaName, character.talkMessage);
    }

    private void SetData(string name, string talkMessage)
    {
        Name = name;
        TalkMessage = talkMessage;
    }
}
