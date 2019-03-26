using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[CreateAssetMenu(menuName = "BanheiroMotherState")]
public class BanheiroMotherState : MotherState
{
    public override void LoadState(Text textComponent, Image imageComponent, Button[] buttonComponents, AdventureGame adventureGame)
    {
        //var banheiros = this.states.Cast<BanheiroState>().ToArray();

        if (Globals.banheiroChave)
        {
            Setup(this.states[1], textComponent, imageComponent, buttonComponents, adventureGame);
        }
        else
        {
            Setup(this.states[0], textComponent, imageComponent, buttonComponents, adventureGame);
        }
    }
}
