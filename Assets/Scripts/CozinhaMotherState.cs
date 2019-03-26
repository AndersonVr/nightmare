using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "CozinhaMotherState")]

public class CozinhaMotherState : MotherState
{
    public override void LoadStates(Text textComponent, Image imageComponent, Button[] buttonComponents) {
        base.LoadStates(textComponent, imageComponent, buttonComponents);
        Globals.banheiroChave = true;
    }
}
