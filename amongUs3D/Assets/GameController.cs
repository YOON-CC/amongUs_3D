using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI textTitle;
    [SerializeField]
    private TextMeshProUGUI textTapToPlay;
    [SerializeField]
    private TextMeshProUGUI TextItemCount;
   
    private int itemCount = 0;
    public bool IsGameStart { private set; get; } // set get�� ���Ͽ� private�� ������ ������ ������ �����ϵ��� �Ѵ�.
    // Start is called before the first frame update
    
    private void Awake()
    {
        IsGameStart = false;

        textTitle.enabled = true;
        textTapToPlay.enabled = true;
        TextItemCount.enabled = false;
    }

    private IEnumerator Start() 
    {
        while(true)
        {
            if(Input.GetMouseButtonDown(0)) // ���콺 ��ư Ŭ�� �������� ������ �������� ����
            {
                IsGameStart = true;

                textTitle.enabled = false;
                textTapToPlay.enabled = false;
                TextItemCount.enabled = true;
                break;
            }
            yield return null;
        }
    }

    public void IncreaseItemCount()
    {
        itemCount++;
        TextItemCount.text = itemCount.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
