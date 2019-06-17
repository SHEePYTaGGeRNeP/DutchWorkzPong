using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : PanelController
{
    [SerializeField]
    private Transform _ball;

    protected override void Update()
    {
        float y = this._ball.transform.position.y - this.transform.position.y;
        this.MoveInput(y);
    }

}
