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

    private void OnTriggerEnter(Collider other)//충돌 체크
    {
        GameObject clone = Instantiate(itemEffectPrefab); //충돌을 하면 이펙트 효과가 발생한다.
        clone.transform.position = transform.position;

        Destroy(gameObject); //아이템을 삭제한다.
    }
}