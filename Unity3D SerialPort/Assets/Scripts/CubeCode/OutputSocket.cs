using UnityEngine;
using System.Collections.Generic;
using System;

public class OutputSocket : Selectable {

    public List<DataLine> connected = new List<DataLine>();

    public void value(int v)
    {
        foreach (DataLine dl in connected)
        {
            dl.value = v;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static implicit operator OutputSocket(GameObject v)
    {
        throw new NotImplementedException();
    }
}
