using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGetData : MonoBehaviour
{
    public Color colorValue;
    public float speedValue;

    public void SaveOnClick()
    {
        DataManager.Instance.color = colorValue;
        DataManager.Instance.speed = speedValue;
        DataManager.Instance.writeData();

    }

    public void LoadOnClick()
    {
        DataManager.Instance.LoadData();
        colorValue = DataManager.Instance.color;
        speedValue = DataManager.Instance.speed;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
