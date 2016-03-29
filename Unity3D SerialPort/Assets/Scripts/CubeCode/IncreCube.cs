using UnityEngine;
using System.Collections;

public class IncreCube : OperatorCube {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void runCycle(int cycle)
    {
        if (cycle == 0) ;
        else
            getOutputs()[0].value(getInputs()[0].value() + 1);
    }
}
