using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Localize : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Delay", 0.1f);
    }

    private void Delay()
    {
        int number = PlayerPrefs.GetInt("Lang");
        ChangeLang(number);
    }



    public void ChangeLang(int lang)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[lang];
        PlayerPrefs.SetInt("Lang", lang);
    }
   
}
