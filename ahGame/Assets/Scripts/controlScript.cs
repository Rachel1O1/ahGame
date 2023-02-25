using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controlScript : MonoBehaviour
{
    public Button openBarButton;
    public Button closeBarButton;
    public Image pollutionBar;
    public Image mask;
    public TextMeshProUGUI moneyDisplay;
    public TextMeshProUGUI powerDisplay;
    public Image controlsMenuScrollings;
    public Button openControlButton;
    public Button closeControlButton;

    public int totalMoney;
    public int totalPower;
    public int currentPower;
    public int maxPollution;
    public int currentPollution;

    void Start()
    {
        totalMoney = 1000;
        totalPower = 0;
        currentPower = 0;
        maxPollution = 10;
        currentPollution = 0;
        moneyDisplay.text = ("$" + totalMoney);
        powerDisplay.text = (currentPower + "/" + totalPower);
        openBarButton.gameObject.SetActive(false);
        closeBarButton.gameObject.SetActive(true);
        pollutionBar.gameObject.SetActive(true);
        moneyDisplay.gameObject.SetActive(true);
        powerDisplay.gameObject.SetActive(true);
        controlsMenuScrollings.gameObject.SetActive(true);
        openControlButton.gameObject.SetActive(false);
        closeControlButton.gameObject.SetActive(true);

        openBarButton.onClick.AddListener(openBar);
        closeBarButton.onClick.AddListener(closeBar);
        openControlButton.onClick.AddListener(openControls);
        closeControlButton.onClick.AddListener(closeControls);
    }

    public void openControls()
    {
        controlsMenuScrollings.gameObject.SetActive(true);
        closeControlButton.gameObject.SetActive(true);
        openControlButton.gameObject.SetActive(false);
    }

    public void closeControls()
    {
        controlsMenuScrollings.gameObject.SetActive(false);
        closeControlButton.gameObject.SetActive(false);
        openControlButton.gameObject.SetActive(true);
    }

    public void openBar()
    {
        pollutionBar.gameObject.SetActive(true);
        closeBarButton.gameObject.SetActive(true);
        openBarButton.gameObject.SetActive(false);
    }

    public void closeBar()
    {
        pollutionBar.gameObject.SetActive(false);
        closeBarButton.gameObject.SetActive(false);
        openBarButton.gameObject.SetActive(true);
    }

    public void GetCurrentFill()
    {
        float fillAmount = (float)currentPollution / (float)maxPollution;
        mask.fillAmount = fillAmount;
    }//https://www.youtube.com/watch?v=J1ng1zA3-Pk

    void Update()
    {
        GetCurrentFill();
    }
}
