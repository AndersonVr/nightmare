using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PortaFechadaHall")]

public class Porta_Fechada_Hall : MotherState
{
    public override void LoadState(AdventureGame adventureGame)
    {
        if (Globals.portaTrancada1)
        {
            Setup(this.states[1], adventureGame);
            Globals.portaTrancada1 = true;
        }
        else
        {
            Setup(this.states[0], adventureGame);
        }
    }
}

