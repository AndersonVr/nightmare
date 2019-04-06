using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HallMother")]

public class Hall_Mother : MotherState
{
    public override void LoadState(AdventureGame adventureGame)
    {   
            Setup(this.states[0], adventureGame);
    }
}
