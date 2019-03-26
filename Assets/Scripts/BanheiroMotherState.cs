using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[CreateAssetMenu(menuName = "BanheiroMotherState")]
public class BanheiroMotherState : MotherState
{
    public override void LoadStates(Text textComponent, Image imageComponent, Button[] buttonComponents)
    {
        //BanheiroState banheiros = (BanheiroState)this.states;
        //var banheiros = this.states.Cast<BanheiroState>().ToArray();

       if (Globals.banheiroChave)
        {
            Load(this.states[1], textComponent, imageComponent, buttonComponents);
        }
        else
        {
            Load(this.states[0], textComponent, imageComponent, buttonComponents);
        }
    }
}
