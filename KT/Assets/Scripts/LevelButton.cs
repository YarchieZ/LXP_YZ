using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private int _levelCount;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform root;

    private void Awake()
    {
        GenerateLevelButtons();
    }

    private void GenerateLevelButtons()
    {
        for (int i = 0; i < _levelCount;  i++)
        {
            Instantiate(buttonPrefab, root);
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
