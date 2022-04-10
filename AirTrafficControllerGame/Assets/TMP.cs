using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMP : MonoBehaviour
{
    private TMP_Text m_TextComponent;

    private void Awake()
    {
        // Get a reference to the text component.
        // Since we are using the base class type <TMP_Text> this component could be either a <TextMeshPro> or <TextMeshProUGUI> component.
        m_TextComponent = GetComponent<TMP_Text>();

        // Change the text on the text component.
        m_TextComponent.text = "Some new line of text.";
    }
}
