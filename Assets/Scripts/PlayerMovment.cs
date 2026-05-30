using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovment : MonoBehaviour
{
    public float speed;
    public CharacterController controller;
    Vector3 velocityl;
    public float gravity = -9.81f;
    public GameObject Puzzle1;
    public GameObject PuzzelAnswer;




    private void Start()
    {
        
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
       
        Vector3 move = transform.right * x + transform.forward * z; 
        controller.Move(move*speed*Time.deltaTime);

        velocityl.y += gravity * Time.deltaTime;

        controller.Move(velocityl * Time.deltaTime);
  
    }
    
}
