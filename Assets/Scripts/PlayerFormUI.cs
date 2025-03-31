using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Handles user input and interacts with SaveManager.
/// This is the only class dealing with the UI.
/// </summary>
public class PlayerFormUI : MonoBehaviour
{
    [Header("Input Fields")]
    public TMP_InputField nameInput;
    public TMP_InputField ageInput;
    public TMP_InputField colorInput;

    [Header("Buttons")]
    public Button saveButton;
    public Button loadButton;
    public Button clearButton;

    private void Start()
    {
        // Assign button events
        saveButton.onClick.AddListener(SaveData);
        loadButton.onClick.AddListener(LoadData);
        clearButton.onClick.AddListener(ClearData);

        Debug.Log("[PlayerFormUI] UI initialized and ready.");
    }

    private void SaveData()
    {
        if (string.IsNullOrEmpty(nameInput.text) || string.IsNullOrEmpty(ageInput.text) || string.IsNullOrEmpty(colorInput.text))
        {
            Debug.LogWarning("[PlayerFormUI] Please fill all fields before saving.");
            return;
        }

        if (!int.TryParse(ageInput.text, out int age))
        {
            Debug.LogWarning("[PlayerFormUI] Age must be a valid number.");
            return;
        }

        PlayerData data = new PlayerData(nameInput.text, age, colorInput.text);
        SaveManager.Instance.Save(data);
    }

    private void LoadData()
    {
        PlayerData data = SaveManager.Instance.Load();
        if (data != null)
        {
            nameInput.text = data.playerName;
            ageInput.text = data.playerAge.ToString();
            colorInput.text = data.favoriteColor;
            Debug.Log("[PlayerFormUI] Data loaded into input fields.");
        }
    }

    private void ClearData()
    {
        SaveManager.Instance.ClearSave();
        nameInput.text = "";
        ageInput.text = "";
        colorInput.text = "";
        Debug.Log("[PlayerFormUI] UI cleared.");
    }
}
