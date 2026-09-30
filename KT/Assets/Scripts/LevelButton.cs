using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private GameObject[] stars;
    [SerializeField] private GameObject locker;
    [SerializeField] private GameObject starRoot;

    public void Init(int levelNumber, int starCount, bool isCompleted)
    {
        if (isCompleted)
        {
            _textMeshPro.text = $"{levelNumber}";
            if (starCount > 0)
            {
                for (int i = 0; i < stars.Length; i++)
                {
                    stars[i].SetActive(i < starCount);
                }
            }
            else
            {
                starRoot.SetActive(false);
            }
            
        }
        else
        {
            locker.SetActive(true);
            starRoot.SetActive(false);
            Button btn = GetComponent<Button>();
            btn.interactable = false;
        }
        
        
    }
}
