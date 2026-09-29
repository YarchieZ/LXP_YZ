using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ChangeMenu : MonoBehaviour
{
    private Button btn;
    [SerializeField] private GameObject currentScreen;
    [SerializeField] private GameObject _nextScreen;

    private void DoTransition()
    {
        currentScreen.SetActive(false);
        _nextScreen.SetActive(true);
    }

    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(DoTransition);
    }
}
