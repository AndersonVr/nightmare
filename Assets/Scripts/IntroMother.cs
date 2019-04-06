using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


[CreateAssetMenu(menuName = "IntroMother")]

public class IntroMother : MotherState
{
    public override void LoadState(AdventureGame adventureGame)
    {
        //var banheiros = this.states.Cast<BanheiroState>().ToArray();

        if (Globals.intro == 1)
        {
            Setup(this.states[0], adventureGame);
                Globals.intro++;
        }
        else if (Globals.intro == 2)
        {
            Setup(this.states[1], adventureGame);
            Globals.intro++;
        }
        else if (Globals.intro == 3)
        {
            Setup(this.states[2], adventureGame);          
        }
    }
}

