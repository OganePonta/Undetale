using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var character = collision.GetComponent<Character>();
        if (character != null)
            character.Talk();
    }
}
