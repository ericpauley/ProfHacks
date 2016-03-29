using UnityEngine;
using System.Collections;

public class KeyboardListener : MonoBehaviour {

    private GameObject mainCam;
    
    void Start()
    {
        mainCam = GameObject.Find("Main Camera");
    }
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            Debug.Log("Detected key code: " + e.keyCode);
            switch (""+e.keyCode)
            {
                case "W":
                    Debug.Log("Bruh");
                    mainCam.GetComponent<ViewPort>().Translate(new Vector3(0, 0, 10));
                    break;
                case "A":
                    mainCam.GetComponent<ViewPort>().Translate(new Vector3(-10, 0, 0));
                    break;
                case "S":
                    mainCam.GetComponent<ViewPort>().Translate(new Vector3(0, 0, -10));
                    break;
                case "D":
                    mainCam.GetComponent<ViewPort>().Translate(new Vector3(10, 0, 0));
                    break;
                    
            }
            
        }


    }

   
}
	
