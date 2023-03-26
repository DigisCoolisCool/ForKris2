using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveController : MonoBehaviour
{
    public float FlySpeed = 5;
    public int Score;
    //public AudioSource Collectible;
    //public Text ScoreText;
    private float Yaw;
    public float Yawmount = 120;
    
    void Start()
    {
        //ScoreText.text = "Score" + Score;
    }

    
    void Update()
    {
        transform.position += transform.forward*FlySpeed*Time.deltaTime;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Yaw += horizontalInput * Yawmount * Time.deltaTime;
        float pitch = Mathf.Lerp(0, 90, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float roll= Mathf.Lerp(0, 20, Mathf.Abs(horizontalInput)) * -Mathf.Sign(horizontalInput);
        transform.localRotation = Quaternion.Euler(Vector3.up * Yaw + Vector3.right * pitch + Vector3.forward * roll);
    }
}
