using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text FruitText;
    public TMP_Text DeathText;

    private int _fruitCount = 0;
    private int _deathCount = 0;

    private void Awake()
    {
        // Si jamais on charge une 2e scene
        // avec un autre GameManager
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddFruit()
    {
        FruitText.text = $"Fruits: {++_fruitCount}";
    }

    public void AddDeath() {
        DeathText.text = $"Death: {++_deathCount}";
    }
}
