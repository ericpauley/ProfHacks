using UnityEngine;
using System.Collections;

public class DataLine : MonoBehaviour {

    public OutputSocket sout;
    public InputSocket sin;
    public int value;
    public int newValue;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        LineRenderer lr = this.gameObject.GetComponent<LineRenderer>();
        Vector3 p1 = sout.transform.GetComponent<Renderer>().bounds.center;
        lr.SetPosition(0, p1);
        if (!sout.connected.Contains(this))
            sout.connected.Add(this);
        Vector3 p2 = sin.transform.GetComponent<Renderer>().bounds.center;
        lr.SetPosition(1, p2);
        sin.connected = this;
        this.gameObject.transform.position = (p1 + p2) / 2;
        this.GetComponent<TextMesh>().text = value.ToString();
	}
}
