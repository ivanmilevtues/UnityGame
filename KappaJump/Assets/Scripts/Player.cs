using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D r2D;
    public GameObject brick;
    public Transform brickPosition;
    // Vector3 brickPostion;
    float jumpSpeed =10f;
    int step = 5;
    void Start () {
        r2D = GetComponent<Rigidbody2D>();
        r2D.velocity = new Vector2(0, jumpSpeed);
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            r2D.velocity = new Vector2(4, r2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            r2D.velocity = new Vector2(-4, r2D.velocity.y);
        }
        if(step < 5)
        {
            //brickPostion = new Vector3(GameObject.Find("brick").transform.x, GameObject.Find("brick").transform.y, 0f);
           // Instantiate(brick,);
        }

    }
    /*void OnTriggerEnter(Collider2D c)
    {
        //if ((c.tag == "brick") && (r2D.velocity.y <= 0))
        //{
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpSpeed);
            //move_cam(c, 15f, jumpSpeed);
        //}
    }*/
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "brick" && r2D.velocity.y <= 0)
        {
            step--;//pochva ot 5
            r2D.velocity = new Vector2(0, jumpSpeed);
            //Debug.Log("Collide is real");
        }
    }
}