# 🧠 Unity Singleton Design Pattern – Player Save System

This project is a **case-study level example** demonstrating the **Singleton Design Pattern** in Unity, combined with basic JSON-based data persistence.

## 🎯 Purpose

The goal of this project is to teach:
- How to use **Singletons** for managing global game data.
- How to create a **lightweight and reusable save/load system**.
- How to safely interact with **UI elements** and serialize data using Unity’s `JsonUtility`.

## 📁 Project Structure

```plaintext
├── PlayerData.cs         # Serializable class representing the player
├── SaveManager.cs        # Singleton-based manager handling save/load operations
└── PlayerFormUI.cs       # UI script that interacts with SaveManager
```

---

## 🔄 Flow Overview

1. `PlayerFormUI` gathers input from the user.
2. When `Save` is clicked:
    - `PlayerData` is constructed.
    - Data is passed to `SaveManager.Instance.Save()`.
3. When `Load` is clicked:
    - Data is fetched from `SaveManager.Instance.Load()`.
    - Input fields are updated.
4. When `Clear` is clicked:
    - Save file is deleted via `SaveManager.Instance.ClearSave()`.

---

## 🧩 Singleton Pattern: `SaveManager`

```csharp
public class SaveManager
{
    private static SaveManager _instance;
    public static SaveManager Instance => _instance ??= new SaveManager();

    private SaveManager() { ... }
}
```

- Ensures **only one instance** is ever used.
- Keeps file path and logic isolated.
- Accessible from **anywhere** in the code using `SaveManager.Instance`.

---

## 💾 File Format

All saved data is serialized as JSON:
```json
{
  "playerName": "John",
  "playerAge": 25,
  "favoriteColor": "Blue"
}
```

Stored at:
```
Application.persistentDataPath/playerdata.json
```

---

## 🧪 Usage

- Attach `PlayerFormUI` to a Canvas GameObject.
- Connect `TMP_InputField` and `Button` references in the inspector.
- Press **Play** and interact with the form:
  - Enter name, age, favorite color.
  - Click **Save**, **Load**, or **Clear**.

---

## ✅ Why this is a Great Singleton Example

- Demonstrates **lazy initialization**.
- Enforces **encapsulation** with private constructor.
- Applies Singleton to a real-world Unity use case: **saving game data**.
- Clean separation of concerns between **UI**, **data model**, and **manager**.

---

## 🧠 Requirements

- Unity 2020.3 or later
- TextMeshPro (TMP)
- Input System or legacy UI

---


## 📜 License

This project is for **educational purposes** and open for extension in larger systems. Free to use and modify.

---
