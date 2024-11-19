using UnityEngine;
using UnityEngine.UI;

public class ButtonCont : MonoBehaviour
{
    public GameObject[] panels; // 패널 배열
    public Button nextBut; // 다음 버튼
    public Button beforeBut; // 이전 버튼
    private int PanelIndex = 0; // 현재 패널 인덱스

    void Awake() 
    {
        // 버튼 클릭 이벤트 리스너 등록
        nextBut.onClick.AddListener(nextPanel);
        beforeBut.onClick.AddListener(beforePanel);

        // 처음에는 첫 번째 패널만 활성화, 나머지는 비활성화
        UpdatePanels();
    }

    void nextPanel()
    {
        if (PanelIndex < panels.Length - 1) 
        {
            PanelIndex++; // 인덱스 증가
            UpdatePanels(); // 패널 업데이트
        }
    }

    void beforePanel()
    {
        if (PanelIndex > 0) 
        {
            PanelIndex--; // 인덱스 감소
            UpdatePanels(); // 패널 업데이트
        }
    }

    // 현재 패널 상태 업데이트
    void UpdatePanels()
    {
        for (int i = 0; i < panels.Length; i++) 
        {
            panels[i].SetActive(i == PanelIndex); // 현재 패널만 활성화
        }
    }
}
