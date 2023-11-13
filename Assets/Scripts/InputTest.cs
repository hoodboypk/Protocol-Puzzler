using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour
{
    public InputField inputField;

    private void Start()
    {
        // Ensure the input field is not null
        if (inputField != null)
        {
            // Add a listener to the input field's OnValueChanged event
            inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
        }
        else
        {
            Debug.LogError("Input Field is not assigned to the script.");
        }
    }

    public void OnInputFieldValueChanged(string text)
    {
        // This method will be called when the input field's value changes
        // Debug.Log("Input Field Value: " + text);

        if(text.ToLower() == "router")
        {
            Debug.Log("Correct Answer!");
        }
    }
}

