using UnityEngine;
using System.Collections;

public class CodeSequencer : MonoBehaviour {

    public int cycle = 0;

    public void runCycle()
    {
        Cube[] cubes = FindObjectsOfType<Cube>();
        foreach (Cube cube in cubes)
        {
            cube.runCycle(cycle);
        }
        DataLine[] lines = FindObjectsOfType<DataLine>();
        foreach (DataLine line in lines)
        {
            line.newValue = line.value;
        }
        cycle++;
    }

    void reset()
    {
        DataLine[] lines = FindObjectsOfType<DataLine>();
        foreach(DataLine line in lines)
        {
            line.value = 0;
        }
        cycle = 0;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
