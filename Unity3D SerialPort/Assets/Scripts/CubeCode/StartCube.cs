using UnityEngine;
using System.Collections;

public class StartCube : ControlCube {

    void OnMouseDown()
    {
        FindObjectOfType<CodeSequencer>().runCycle();
    }

    public override void runCycle(int cycle)
    {
        if(cycle == 0)
            this.getOutputs()[0].value(1);
        else
            this.getOutputs()[0].value(0);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
