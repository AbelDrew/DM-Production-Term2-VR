using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppendInputField : MonoBehaviour
{

    public InputField m_inputField;

    public void appendField(string appendString)
    {
        string tempString = m_inputField.text + appendString;
        m_inputField.text = tempString;

    }

}
