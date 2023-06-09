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
    public bool IsGameStart { private set; get; } // set get을 통하여 private로 선언한 변수에 접근이 가능하도록 한다.
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
            if(Input.GetMouseButtonDown(0)) // 마우스 버튼 클릭 전가지는 게임을 시작하지 않음
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
