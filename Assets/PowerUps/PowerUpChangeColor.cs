using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpChangeColor : BasePowerUp
{
    protected override bool ApplyToPlayer(Player thePickerUpper) {
        thePickerUpper.PlayerColor1.Value = Color.black;
        return true;
    }
}
