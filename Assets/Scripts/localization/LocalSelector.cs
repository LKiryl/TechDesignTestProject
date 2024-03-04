using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalSelector : MonoBehaviour
{
    private bool _active = false;
    private int _id;
    private void Start()
    {
        
        _id = PlayerPrefs.GetInt("LocalKey", 0);
        ChangeLocale(_id);

        
    }
    public void ChangeLocale(int id)
    {
        if(_active) { return; }
        StartCoroutine(SetLocale(id));
    }
    private IEnumerator SetLocale(int id)
    {
        _active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[id];
        PlayerPrefs.SetInt("LocalKey", id);
        _active = false;
    }
}
