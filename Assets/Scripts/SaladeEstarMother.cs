using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SaladeEstarMother")]

public class SaladeEstarMother : MotherState
{
    public override void LoadState(AdventureGame adventureGame)
    {
        if (Globals.QuartoSenhoraLobo || Globals.loboVisto)
        {
            Setup(this.states[1], adventureGame);
        }
        else
        {
            Setup(this.states[0], adventureGame);
        }
    }
}
