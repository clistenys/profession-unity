using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CodeUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickButton()
    {
        gameObject.GetComponent<Text>().text = gameObject.name;
    }
}
