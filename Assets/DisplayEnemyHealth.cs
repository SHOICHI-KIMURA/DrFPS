using UnityEngine;
using TMPro;

public class DisplayEnemyHealth : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textComponent;

    [SerializeField]
    private Target Target; // Reference to the enemy Target script

    void Start()
    {
        if (textComponent == null)
        {
            Debug.LogError("Text Component is not assigned in the inspector");
        }

        if (Target == null)
        {
            Debug.LogError("Enemy Target is not assigned in the inspector");
        }
    }

    public void UpdateText(string newText)
    {
        if (textComponent != null)
        {
            textComponent.SetText(newText);
        }
    }

  
    }
