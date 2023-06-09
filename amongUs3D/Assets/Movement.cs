using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private GameController gameController;

    [SerializeField]
    private float moveSpeed = 0.0f; //������ �ʱ�ȭ.. ���� ���� ������Ʈ�� �Է��� �Ѵ�.
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameController.IsGameStart == false) return;

        transform.position += Vector3.forward * moveSpeed * Time.deltaTime; // z���� �̵�
    }
}
