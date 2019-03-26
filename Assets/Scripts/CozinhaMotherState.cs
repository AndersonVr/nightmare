using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CozinhaMotherState")]
public class CozinhaMotherState : MotherState
{
    public override void LoadState(Text textComponent, Image imageComponent, Button[] buttonComponents, AdventureGame adventureGame) {
        base.LoadState(textComponent, imageComponent, buttonComponents, adventureGame);
        Globals.banheiroChave = true;
    }
}
