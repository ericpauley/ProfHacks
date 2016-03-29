using UnityEngine;
using System.Collections;

public class PhysicsPointerSphere : MonoBehaviour
{

    private UnitySerialPort unitySerialPort;
    public GameObject mainCam;
    public GameObject over = null;
    public GameObject selected = null;

    public DataLine dlPrefab;

    public DataLine selectorLine;

    public bool pressed = false;

    // Use this for initialization
    void Start()
    {
        unitySerialPort = UnitySerialPort.Instance;
        unitySerialPort.OpenSerialPort();
        selectorLine = Instantiate(dlPrefab);
        mainCam = GameObject.Find("Main Camera");
    }

    void OnTriggerEnter(Collider col)
    {
        if (!pressed)
        {
            over = col.gameObject;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (!pressed)
        {
            over = col.gameObject;
        }
    }
    void OnTriggerExit(Collider col)
    {
        over = null;
    }

    // Update is called once per frame
    void Update()
    {
        
        string[] parts = unitySerialPort.RawData.Split(' ');
        if (parts.Length < 3)
        {
            return;
        }
        Vector3 newPos = new Vector3(float.Parse(parts[1]), 45, float.Parse(parts[2]));
        this.gameObject.transform.position = newPos;
    

      
    }
}
