using UnityEngine;
using System.Collections;

public class CameraMovement : Player {

	// Use this for initialization
	void Start () {
	
	}
    float move = 0.2f;
    int frames = 0;
    public int frameCheck;
    public GameObject Brick;
    public Transform BrickPosition;
    Vector3 xyz;
    


	// Update is called once per frame
	void Update () {
        xyz = new Vector3(transform.position.x + 5,transform.position.y + 5, 0);
        frames++;
        if(frames % frameCheck == 0)
        {
             this.transform.Translate(0f, move , 0f);
             move = move + 0.00000000001f;
             frames = 0;
        }
        if(frames < 5)
        {
             Instantiate(Brick, xyz, BrickPosition.rotation);
        }
    }
}