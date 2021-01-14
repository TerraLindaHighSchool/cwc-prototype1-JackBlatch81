using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
   //fields
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float rudderSpeed;
    private int point;
    private Rigidbody rb;
    public TextMeshProUGUI pointText;
    public GameObject plane;
    private GameManagerX gameManager;
    public ParticleSystem deathParticle;
    

    // Start is called before the first frame update
    void Start()
    {
        //for calling compoenents/ setting integers and calling methods
        rb = GetComponent<Rigidbody>(); 
        point = 0;
        SetPointText();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // tilt the plane left to right based on left and right keys
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * horizontalInput);

        //for rudders
        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.up * rudderSpeed * Time.deltaTime);
        }

        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.down * rudderSpeed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //for updating point text
        if(other.gameObject.CompareTag("Point"))
        {
            other.gameObject.SetActive(false);
            point = point + 1;
            

            SetPointText();
        }
          
    }

    void SetPointText()
    {
        //for updating point text
        pointText.text = "Points: " + point.ToString(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        //for destroying plane and displaying game over text
        if (collision.gameObject.CompareTag("Map"))
        {
            Cursor.visible = true;
            Destroy(gameObject);
            Instantiate(deathParticle, transform.position, deathParticle.transform.rotation);
            gameManager.GameOver();
        }

        //fpr displaying win text 
        if(collision.gameObject.CompareTag("Finish") && point >= 6)
        {
            Cursor.visible = true;
            Destroy(gameObject);
            gameManager.Win();
        }

        //for displaying lose text when player finishes with not enough points
        if (collision.gameObject.CompareTag("Finish") && point < 6)
        {
            Cursor.visible = true;
            Destroy(gameObject);
            Instantiate(deathParticle, transform.position, deathParticle.transform.rotation);
            gameManager.Lose();
        }
    }
    
}
