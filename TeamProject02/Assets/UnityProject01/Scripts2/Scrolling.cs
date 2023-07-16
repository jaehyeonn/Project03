using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    

    public float speed = 10f; //이동속도
    private float width;

    private Player player;


    private void Awake()
    {
        BoxCollider2D backgrooundCollider = GetComponent<BoxCollider2D>();
        width = backgrooundCollider.size.x;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.isDead == true)
        {
            return;
        }

        float horizon = Input.GetAxis("Horizontal");
        float movement = horizon * 6 * Time.deltaTime;
        transform.Translate(Vector3.left * movement);

        //transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= -width )
        {
            Reposition();
        }
        if (transform.position.x >= width ) 
        {
            Reposition2();
        }
       
    }
    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0f);
        //transform.position = (Vector2)transform.position + offset;
        transform.position = transform.position.AddVector(offset);
    }
    private void Reposition2()
    {
        Vector2 offset = new Vector2(width * -2f, 0f);
        //transform.position = (Vector2)transform.position + offset;
        transform.position = transform.position.AddVector(offset);
    }
}
