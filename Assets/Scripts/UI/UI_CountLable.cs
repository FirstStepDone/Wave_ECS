using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Text))]
public class UI_CountLable : MonoBehaviour
{
    [SerializeField] private InitializationSystem _initializationSystem;

    private void Awake()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Count - " + _initializationSystem.EntityCount.ToString();
    }
}
