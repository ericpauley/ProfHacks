using UnityEngine;
using System.Collections;

public class EqualCube : LogicCube {

    public override void runCycle(int cycle)
    {
        if (cycle == 0) ;
        else
        {
            if (getInputs()[0].value() == getInputs()[1].value())
                getOutputs()[0].value(1);
            else
                getOutputs()[0].value(0);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
