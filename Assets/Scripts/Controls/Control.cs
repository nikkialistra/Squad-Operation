// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/Control.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Controls
{
    public class @Control : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Control()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control"",
    ""maps"": [
        {
            ""name"": ""Selection"",
            ""id"": ""937de7b6-160c-4f41-ab4c-3ba811c7a341"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""8b08c837-1d52-420e-87fc-e37e0af2df12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Finish"",
                    ""type"": ""Button"",
                    ""id"": ""33983b20-523e-4ff1-90d0-4c791f04917b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""aa850bc3-23c5-4dc9-918e-d377451e04d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a4e9efaa-4a74-409a-9658-d3a1d9e5dc5d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4bbf6a0-5bdf-48f4-a2dc-7a8c5066fc2b"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ceb758f8-e4dc-4bba-84a8-89bfead00da5"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f18367c8-e6df-476e-a1de-965768099c0f"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3724b642-27f3-4e72-a436-9073fd148381"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Finish"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26f916d0-887d-438c-b8a4-c5919b4275bb"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Finish"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Phone"",
            ""bindingGroup"": ""Phone"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Selection
            m_Selection = asset.FindActionMap("Selection", throwIfNotFound: true);
            m_Selection_Start = m_Selection.FindAction("Start", throwIfNotFound: true);
            m_Selection_Finish = m_Selection.FindAction("Finish", throwIfNotFound: true);
            m_Selection_Position = m_Selection.FindAction("Position", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Selection
        private readonly InputActionMap m_Selection;
        private ISelectionActions m_SelectionActionsCallbackInterface;
        private readonly InputAction m_Selection_Start;
        private readonly InputAction m_Selection_Finish;
        private readonly InputAction m_Selection_Position;
        public struct SelectionActions
        {
            private @Control m_Wrapper;
            public SelectionActions(@Control wrapper) { m_Wrapper = wrapper; }
            public InputAction @Start => m_Wrapper.m_Selection_Start;
            public InputAction @Finish => m_Wrapper.m_Selection_Finish;
            public InputAction @Position => m_Wrapper.m_Selection_Position;
            public InputActionMap Get() { return m_Wrapper.m_Selection; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SelectionActions set) { return set.Get(); }
            public void SetCallbacks(ISelectionActions instance)
            {
                if (m_Wrapper.m_SelectionActionsCallbackInterface != null)
                {
                    @Start.started -= m_Wrapper.m_SelectionActionsCallbackInterface.OnStart;
                    @Start.performed -= m_Wrapper.m_SelectionActionsCallbackInterface.OnStart;
                    @Start.canceled -= m_Wrapper.m_SelectionActionsCallbackInterface.OnStart;
                    @Finish.started -= m_Wrapper.m_SelectionActionsCallbackInterface.OnFinish;
                    @Finish.performed -= m_Wrapper.m_SelectionActionsCallbackInterface.OnFinish;
                    @Finish.canceled -= m_Wrapper.m_SelectionActionsCallbackInterface.OnFinish;
                    @Position.started -= m_Wrapper.m_SelectionActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_SelectionActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_SelectionActionsCallbackInterface.OnPosition;
                }
                m_Wrapper.m_SelectionActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Start.started += instance.OnStart;
                    @Start.performed += instance.OnStart;
                    @Start.canceled += instance.OnStart;
                    @Finish.started += instance.OnFinish;
                    @Finish.performed += instance.OnFinish;
                    @Finish.canceled += instance.OnFinish;
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                }
            }
        }
        public SelectionActions @Selection => new SelectionActions(this);
        private int m_PCSchemeIndex = -1;
        public InputControlScheme PCScheme
        {
            get
            {
                if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
                return asset.controlSchemes[m_PCSchemeIndex];
            }
        }
        private int m_PhoneSchemeIndex = -1;
        public InputControlScheme PhoneScheme
        {
            get
            {
                if (m_PhoneSchemeIndex == -1) m_PhoneSchemeIndex = asset.FindControlSchemeIndex("Phone");
                return asset.controlSchemes[m_PhoneSchemeIndex];
            }
        }
        public interface ISelectionActions
        {
            void OnStart(InputAction.CallbackContext context);
            void OnFinish(InputAction.CallbackContext context);
            void OnPosition(InputAction.CallbackContext context);
        }
    }
}
