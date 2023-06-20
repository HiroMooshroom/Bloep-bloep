using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Transform checkpoint;
    public Vector3 startPos;
    public float speed;
    public float horizontal;
    public float vertical;
    public bool collidingDoorTrigger;
    public Vector3 moveDirection;
    public bool canMove;
    public int playerPrefsint;



    private void Start()
    {
        startPos = new Vector3(0f, 0.5f, 0f);
        if (PlayerPrefs.HasKey("xPos"))
        {
            startPos.x = PlayerPrefs.GetFloat("xPos");
        }
        if (PlayerPrefs.HasKey("yPos"))
        {
            startPos.y = PlayerPrefs.GetFloat("yPos");
        }
        if (PlayerPrefs.HasKey("zPos"))
        {
            startPos.z = PlayerPrefs.GetFloat("zPos");
        }
        if(PlayerPrefs.GetInt("StartRespawn") == 1)
        {
            transform.position = startPos;
            PlayerPrefs.SetInt("StartRespawn", 0);
        }
    }
    void Update()
    {
        if (canMove ==  true)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            moveDirection.x = horizontal;
            moveDirection.z = vertical;

            transform.Translate(moveDirection * speed * Time.deltaTime);
        }
        if(canMove == false)
        {
            print("you cannot move");
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerDoorClosing"))
        {
            collidingDoorTrigger = true;
        }
    }

    public void Death()
    {
        PlayerPrefs.SetFloat("xPos", checkpoint.transform.position.x);
        PlayerPrefs.SetFloat("yPos", checkpoint.transform.position.y);
        PlayerPrefs.SetFloat("zPos", checkpoint.transform.position.z);
        PlayerPrefs.SetInt("StartRespawn", 1);
        SceneManager.LoadScene("MainGame");
    }
}
