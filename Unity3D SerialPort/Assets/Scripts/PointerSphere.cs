using UnityEngine;
using System.Collections;

public class PointerSphere : MonoBehaviour {

    private UnitySerialPort unitySerialPort;
    public GameObject mainCam;
    public GameObject over = null;
    public GameObject selected = null;

    public DataLine dlPrefab;

    public DataLine selectorLine;

    public bool pressed = false;
    
    // Use this for initialization
    void Start () {
        unitySerialPort = UnitySerialPort.Instance;
        unitySerialPort.OpenSerialPort();
        selectorLine = Instantiate(dlPrefab);
        mainCam = GameObject.Find("Main Camera");

    }

    void OnTriggerEnter(Collider col)
    {
        if (!pressed) {
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
        if(selected != null)
        {
            selectorLine.sin = selected.GetComponent<InputSocket>();
            if(selectorLine.sin == null)
            {
                selectorLine.sin = this.GetComponent<InputSocket>();
            }
            selectorLine.sout = selected.GetComponent<OutputSocket>();
            if (selectorLine.sout == null)
            {
                selectorLine.sout = this.GetComponent<OutputSocket>();
            }
        }
        else
        {
            selectorLine.sin = this.GetComponent<InputSocket>();
            selectorLine.sout = this.GetComponent<OutputSocket>();
        }
        string[] parts = unitySerialPort.RawData.Split(' ');
        if (parts.Length < 3)
        {
            return;
        }
        Vector3 newPos = new Vector3(float.Parse(parts[1]) * 2, 40, float.Parse(parts[2]) * 2) + mainCam.GetComponent<ViewPort>().globalOffset;

        Vector3 diff = newPos - this.gameObject.transform.position;
        this.gameObject.transform.position = newPos;
        if (parts[3] == "0")
        {
            this.pressed = true;
            if(over != null && !over.GetComponent<Selectable>())
            {
                over.transform.Translate(diff, Space.World);
            }
            
        }
        else
        {
            if (pressed == true)
            {
                Debug.Log("Candidate to select", over);
                this.pressed = false;
                if (over != null && over.GetComponent<Selectable>())
                {
                    Debug.Log("Able to select", over);
                    if (selected == null)
                    {
                        selected = over;
                        over = null;
                    }
                    else
                    {
                        if (over.GetComponent<InputSocket>() && selected.GetComponent<OutputSocket>())
                        {
                            DataLine dl = Instantiate(dlPrefab);
                            dl.sin = over.GetComponent<InputSocket>();
                            dl.sout = selected.GetComponent<OutputSocket>();

                        }
                        else if (over.GetComponent<OutputSocket>() && selected.GetComponent<InputSocket>())
                        {
                            DataLine dl = Instantiate(dlPrefab);
                            dl.sin = selected.GetComponent<InputSocket>();
                            dl.sout = over.GetComponent<OutputSocket>();
                        }
                        selected = null;
                        over = null;
                    }
                }
                
            }
            else
            {

            }
                
        }
    }
}
