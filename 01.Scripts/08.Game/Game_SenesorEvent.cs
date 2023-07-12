using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_SenesorEvent : MonoBehaviour
{

    public void OnClick_ConnectBtn()
    {
        ArduinoHM10Test2.instance.StartProcess();
        SoundFunction.Instance.ButtonClick_Sound();
    }

}
