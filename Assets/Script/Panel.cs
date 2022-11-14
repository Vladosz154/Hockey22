using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{

    public GameObject panel;
    public void Panels()
    {
        panel.SetActive(true);
    }
    public void PanelExit()
    {
        panel.SetActive(false);
    }
}
