using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterScript : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public Button CountButton;
    public Button resetButton;
    private int countNumber = 0; 

    void Start()
    {
        UpdateUI();
        
        
        if (CountButton != null) {
            CountButton.onClick.RemoveAllListeners();
            CountButton.onClick.AddListener(Count);
        }
            
        if (resetButton != null) {
            resetButton.onClick.RemoveAllListeners();
            resetButton.onClick.AddListener(ResetCounter);
        }
    }

    public void Count()
    {
        countNumber++;
        UpdateUI();
    }

    public void ResetCounter()
    {
        countNumber = 0;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (countText != null)
            countText.text = countNumber.ToString();
    }
}