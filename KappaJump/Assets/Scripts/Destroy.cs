using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    bool InRange = true;
	// Update is called once per frame
	void Update () {
        if (!InRange)
        {
            Destroy(this.gameObject);
        }
	}
}
