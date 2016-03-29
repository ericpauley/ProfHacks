using UnityEngine;
using System.Collections;

public class ViewPort : MonoBehaviour {

    public Vector3 globalOffset;
    public Vector3 initPos;
    void Start()
    {
        globalOffset = new Vector3(0, 0, 0);
        initPos = new Vector3(0, 800, 0);
        this.gameObject.transform.position = globalOffset + initPos;
    }
	// Update is called once per frame
	void Update () {
            this.gameObject.transform.position = initPos + globalOffset;
	}

    public void Translate(Vector3 delta)
    {
        
        globalOffset += delta;
    }
}
