using Services;
using UnityEngine;
using UnityEngine.UI;

namespace Saving.UI
{
    [RequireComponent(typeof(Button))]
    public class LoadButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void Start()
        {
            _button.onClick.AddListener(GameEvents.Instance.Load);
        }
    }
}