using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JohnMovement : MonoBehaviour
{

    public float JumpForce;
    public float Speed;

    private Rigidbody2D Rigidbody2D;
    private float Horizontal;

    private bool Grounded;
    private Animator Animator;

    //Bala
    public GameObject BulletPrefab;
    private float Cooldown;
    

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Horizontal = Input.GetAxisRaw("Horizontal");
        Debug.Log(Horizontal);
        Animator.SetBool("running", Horizontal != 0.0f);

        if (Horizontal < 0.0f)
        {
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }
        else if (Horizontal > 0.0f) 
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        } else
        {
            Grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }

        //Bala
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > Cooldown + 0.25f)
        {
            Shoot();
            Cooldown = Time.time;
        }
    }

    private void Jump()
    {
        Vector2 aux = Rigidbody2D.velocity;
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
        Rigidbody2D.velocity = aux;
    }

    private void Shoot()
    {
        Vector3 dir;
        if (transform.localScale.x == 1.0f) dir = Vector2.right;
        else dir = Vector2.left;

        GameObject bullet = Instantiate(BulletPrefab, transform.position + dir * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().setDirection(dir);
    }


    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y) * Speed;
    }

    public void SalisteDelVideojuego()
    {
        Destroy(gameObject);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
