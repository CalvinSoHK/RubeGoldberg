using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            //GetComponent<Rigidbody>().AddForce(new Vector3(0, 500f, 0));
        }
	}
}
