using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;

public class LoadLocalizationData : MonoBehaviour
{
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        LocalizationManager.Read();
        LocalizationManager.Language = "Polish";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
