using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] areaBox; //������ �迭
    [SerializeField]
    private int AreaCount = 3; //ó���� ������ �Ǵ� ���� �����̴�.
    [SerializeField]
    private float zDistance = 20; //���� ����
    private int areaIndex = 0;

    [SerializeField]
    private Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i< AreaCount; ++i)// ������ �����Ѵ�.
        {
            if(i==0) // ù��° ������ ���� ó�� 0�� �������� �����Ѵ�.
            {
                SpawnArea(false);
            }
            else
            {
                SpawnArea(); //0���� ��� ������ �ȴ�.
            }
        }
    }
    //��, ó������ 0���� �����Ͽ� false�� �Է��̵Ǿ� ù��° ������ ������ �Ǹ� ���� SpawnArea�� true�� �ش��ϴ� ���ǹ����� �������� ���� ȣ���� �ȴ�.
    public void SpawnArea(bool isRandom = true) // �⺻���� true�̱� ������ ���� ���ٸ� true�� ������ �ȴ�.
    {
        GameObject map = null;

        if(isRandom == false)
        {
            map = Instantiate(areaBox[0]); // ���� ó�� ���� ���� => instantiate�� ������Ʈ�� �����Ѵ�.
        }
        else
        {
            int index = Random.Range(0, areaBox.Length);
            map = Instantiate(areaBox[index]);
        }

        //���� ���� z��󿡼� ���� index���� ���� ���� ��ġ�� ���� ���� ����
        map.transform.position = new Vector3(0, 0, areaIndex * zDistance);

        //Area��ũ��Ʈ setup �Լ� ȣ��
        map.GetComponent<Area>().Setup(this, playerTransform);

        areaIndex++; // ���� ���� ������ ������ 1 �������� ������Ų��. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
