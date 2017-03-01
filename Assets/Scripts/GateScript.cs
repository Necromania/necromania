using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour {

    public int requiredSkeletons = 10;

    public void OpenGate(int currentSkeletons)
    {
        if (currentSkeletons >= requiredSkeletons)
            gameObject.SetActive(false);
    }
}
