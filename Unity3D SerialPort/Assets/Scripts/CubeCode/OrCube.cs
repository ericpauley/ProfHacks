using UnityEngine;
using System.Collections;

public class OrCube : LogicCube {

    public override void runCycle(int cycle)
    {

        if (getInputs()[0].value() >= 1 || getInputs()[1].value() >= 1)
        {
            getOutputs()[0].value(1);
        }
        else
        {
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
