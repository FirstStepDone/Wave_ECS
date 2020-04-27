using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Text))]
public class UI_TypeLable : MonoBehaviour
{
    [SerializeField] private InitializationSystem _initialization;

    private void Awake()
    {
        GetComponent<UnityEngine.UI.Text>().text = _initialization.IsECS ? "Entities" : "GameObjects";
    }
}
