using UnityEngine;
using System.Collections;

public abstract class Cube : MonoBehaviour {

    public abstract void runCycle(int cycle);

    protected InputSocket[] getInputs()
    {
        return this.GetComponentsInChildren<InputSocket>();
    }

    protected OutputSocket[] getOutputs()
    {
        return this.GetComponentsInChildren<OutputSocket>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
