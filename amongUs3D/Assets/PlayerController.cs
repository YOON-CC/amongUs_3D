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
            this.transform.Translate(-0.05f, 0.0f, 0.0f); // ���� �̵�
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.05f, 0.0f, 0.0f); // ������ �̵� 
        }
        if (Input.GetKeyDown(KeyCode.Space)) // ���� 
        {
            if(!IsJumping)
            {
                IsJumping = true;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);// ������ �����ش�.������ٵ� ���� �߰�����.
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
