using UnityEngine;
using System.Collections;

public class PulseCube : ControlCube {
    private int pulseEndCycle;
    private bool activated = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public override void runCycle(int cycle)
    {
        if (!activated)
        {
            if (getInputs()[0].value() == 0) ;
            else
            {
                activated = true;
                pulseEndCycle = cycle + getInputs()[1].value();
                getOutputs()[0].value(1);
            }
        } else
        {
            if (cycle < pulseEndCycle)
            {
                getOutputs()[0].value(1);

            }
            else
            {
                getOutputs()[0].value(0);
            }
        }
    }
}
