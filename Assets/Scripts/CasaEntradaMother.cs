using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CasaEntrada")]

public class CasaEntradaMother : MotherState
{
    public override void LoadState(AdventureGame adventureGame)
    {
        if (Globals.casaEntrada2)
        {
            Setup(this.states[1], adventureGame);
        }
        else
        {
            Setup(this.states[0], adventureGame);
        }
    }
}
