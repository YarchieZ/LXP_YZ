using UnityEngine;

public class LevelButtonGenerator : MonoBehaviour
{
    [SerializeField] private int levelCount;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform root;
    [SerializeField] private int CompletedLevelCount;

    private void Awake()
    {
        GenerateLevelButtons();
    }

    private void GenerateLevelButtons()
    {
        for (int i = 0; i < levelCount;  i++)
        {
            var instance = Instantiate(buttonPrefab, root);
            if (instance.TryGetComponent(out LevelButton btn))
            {
                int levelNumber = i + 1;
                int starCount = Random.Range(1, 4);
                if (i == CompletedLevelCount)
                {
                    btn.Init(levelNumber, 0, true);
                }
                else
                {
                    btn.Init(levelNumber, starCount, i < CompletedLevelCount);
                }
                
            }
        }
    }

    private void ClearRoot()
    {
        for (int i = 0; i < root.childCount; ++i)
        {
            Destroy(root.GetChild(i).gameObject);
        }
    }
}
