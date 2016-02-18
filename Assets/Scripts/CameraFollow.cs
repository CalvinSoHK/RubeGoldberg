using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject follow;
    Vector3 difference;
	
    void Start()
    {
        difference = follow.transform.position - transform.position;
    }

	// Update is called once per frame
	void Update () {
        transform.position = follow.transform.position - difference;
	}
}
