using UnityEngine;
using System.Collections;

public class TurnCube : CommandCube {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public override void runCycle(int cycle)
    {
        //Debug.Log(getInputs()[0].value() + " asdfasdfsadf");
        if (getInputs()[0].value() == 1) {
            GameObject.Find("Figure").transform.Rotate(0, 0, 90, Space.Self);

            Debug.Log(getInputs()[0].value() + " asdfasdfsadf");
        }
        else if (getInputs()[0].value() == -1)
            GameObject.Find("Figure").transform.Rotate(Vector3.left, Space.World);
        else;

    }
}
