using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;
public class LocalizationHandler : MonoBehaviour
{
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
