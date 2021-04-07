using Infrastructure.Signals;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Infrastructure.Events
{
    [RequireComponent(typeof(Button))]
    public class SaveEvent : MonoBehaviour
    { 
        private Button _button;

        private SignalBus _signalBus;

        [Inject]
        public void Construct(SignalBus signalBus) => _signalBus = signalBus;

        private void Awake() => _button = GetComponent<Button>();

        private void OnEnable() => _button.onClick.AddListener(Save);

        private void OnDisable() => _button.onClick.RemoveListener(Save);

        private void Save() => _signalBus.Fire<SaveSignal>();
    }
}