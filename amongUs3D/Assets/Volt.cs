using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volt: MonoBehaviour
{
    [SerializeField]
    private GameObject itemEffectPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)//�浹 üũ
    {
        GameObject clone = Instantiate(itemEffectPrefab); //�浹�� �ϸ� ����Ʈ ȿ���� �߻��Ѵ�.
        clone.transform.position = transform.position;

        Destroy(gameObject); //�������� �����Ѵ�.
    }
}