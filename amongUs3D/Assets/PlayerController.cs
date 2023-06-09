using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigid;

    public int JumpPower;
    public int MoveSpeed;

    public bool IsJumping;
    
    public AudioSource mySfx;
    public AudioClip jumpSfx;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        IsJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    private void Moving()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.05f, 0.0f, 0.0f); // 왼쪽 이동
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.05f, 0.0f, 0.0f); // 오른쪽 이동 
        }
        if (Input.GetKeyDown(KeyCode.Space)) // 점프 
        {
            if(!IsJumping)
            {
                IsJumping = true;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);// 점프를 시켜준다.리지드바디에 힘을 추가해줌.
                JumpSound();
            }

            else
            {
                return;
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            IsJumping = false;
        }
    }

    private void JumpSound()
    {
        mySfx.PlayOneShot(jumpSfx);
    }
}
