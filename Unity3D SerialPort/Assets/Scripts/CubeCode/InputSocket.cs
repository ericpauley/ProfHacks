using UnityEngine;
using System.Collections;
using System;

public class InputSocket : Selectable {

    // Use this for initialization

    public DataLine connected;

    public int value()
    {
        if (connected != null)
            return connected.newValue;
        else
            return 0;
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static implicit operator InputSocket(GameObject v)
    {
        throw new NotImplementedException();
    }
}
