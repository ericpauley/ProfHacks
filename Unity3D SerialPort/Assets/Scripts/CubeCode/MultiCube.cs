using UnityEngine;
using System.Collections;

public class MultiCube : OperatorCube {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void runCycle(int cycle)
    {
        getOutputs()[0].value(getInputs()[0].value() * getInputs()[1].value());
    }
}
