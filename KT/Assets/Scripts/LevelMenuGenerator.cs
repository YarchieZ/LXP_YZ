using TMPro;
using UnityEngine;

public class LevelMenuGenerator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;

    public void Init(int levelNumber)
    {
        _textMeshPro.text = $"{levelNumber}";
    }
}
