using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private string Name { set; get; }
    private string TalkMessage { get; set; }

    public void Talk()
    {
        Debug.Log(Name + " : " + TalkMessage);
    }
}
