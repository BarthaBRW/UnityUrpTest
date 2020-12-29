using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{
    public Player player;
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
        OnHealthChanged(player.GetHealth());
        player.OnHealthChanged += OnHealthChanged;
    }

    private void OnHealthChanged(float health)
    {
        text.text = health.ToString("0");
    }
}
