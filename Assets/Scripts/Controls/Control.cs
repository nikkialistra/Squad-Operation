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
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""8b08c837-1d52-420e-87fc-e37e0af2df12"",
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
                    ""id"": ""f4bbf6a0-5bdf-48f4-a2dc-7a8c5066fc2b"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00e3ec2b-0b5f-49aa-b9ea-2bc1ffa38571"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Select"",
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
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""4cc9433d-d740-4593-a299-245a457e2ffd"",
            ""actions"": [
                {
                    ""name"": ""SetFollow"",
                    ""type"": ""Button"",
                    ""id"": ""3a2302e8-af2d-4adc-bae2-e850d2eaa14b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResetFollow"",
                    ""type"": ""Button"",
                    ""id"": ""e72a7247-f0fc-4d95-826c-d8c03af268d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""5b30397d-7042-4124-b7a9-ab744acc472a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""d6a2616d-3501-4776-b0e6-9bd0f48d43b4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drag"",
                    ""type"": ""Button"",
                    ""id"": ""d1531ab8-d879-4368-96bb-d14c4c98fe0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""d1445202-5a7e-4b4c-864f-a13dd7c187d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastMovement"",
                    ""type"": ""Button"",
                    ""id"": ""0aa97f6a-e3f3-4d8f-8ead-af1cd626fdd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a08e44b6-96db-4738-afa7-f075bafe4bdf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""862651f6-dc28-4bde-a835-01291b3077b5"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""141de89e-0dc4-4a48-bf02-3f6283acbf65"",
                    ""expectedControlType"": ""Digital"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2d0e6b84-dafe-4c53-89ef-b2fba507309f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ResetFollow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""7f23b91f-67a3-4631-bde7-07511c16f1f0"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetFollow"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""9e3f8d34-eb9a-4611-9be3-fea0cf5ba263"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""SetFollow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""d57f1661-b86a-45d5-9174-a14ec713410f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""SetFollow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""05ce1a5d-637e-4c6c-971d-d426b07f44d3"",
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
                    ""id"": ""d268ebbb-6978-48b2-b70b-abcdc96a7c7d"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""66bb381d-0e91-4112-b826-c05ed77cb14a"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""99d3119b-4064-432f-900f-948f5de600c9"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""7c25853f-7e67-4e00-b2fd-d9f9a5f4265f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fe5b6366-da1c-414a-a473-4014542b175d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""331cbbc5-8353-4066-9c37-2ee23c53ef15"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""FastMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""06620c29-a204-42ac-8041-11e75e5171de"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2d7a783f-c0ba-44b0-b121-ce9aa443ce39"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""93d8d940-be56-4044-a0a9-16b8128a8e1f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a886be5f-f36c-48b4-a5f5-eadf136da2f9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3c329feb-b09c-4955-bd83-7111318addee"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8bd81bf0-9177-46e2-83cb-5188acd0ee76"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""09cbffb9-f22b-406c-8132-38658d51915b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""51711646-ead8-40f0-8b53-a43d6a264301"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""87ca861a-8e3d-4c54-b441-cd3043588626"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d91ea792-9a77-4041-a96d-ee6410f5c610"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""11304acd-7a97-4df6-be95-961f09dab8bf"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Targeting"",
            ""id"": ""105cae15-13b2-4182-9dfc-b09591e954ac"",
            ""actions"": [
                {
                    ""name"": ""SetTarget"",
                    ""type"": ""Button"",
                    ""id"": ""ecf34649-68ae-48ca-9108-199907908eb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""186d512c-b03c-4c99-b582-1e8c561a6546"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""55b9c16e-ef7f-4fbf-9903-cc3a750fff18"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""SetTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd9dc82a-78e7-43a5-919f-5bc41915b499"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Position"",
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
            m_Selection_Select = m_Selection.FindAction("Select", throwIfNotFound: true);
            m_Selection_Position = m_Selection.FindAction("Position", throwIfNotFound: true);
            // Camera
            m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
            m_Camera_SetFollow = m_Camera.FindAction("SetFollow", throwIfNotFound: true);
            m_Camera_ResetFollow = m_Camera.FindAction("ResetFollow", throwIfNotFound: true);
            m_Camera_Position = m_Camera.FindAction("Position", throwIfNotFound: true);
            m_Camera_Scroll = m_Camera.FindAction("Scroll", throwIfNotFound: true);
            m_Camera_Drag = m_Camera.FindAction("Drag", throwIfNotFound: true);
            m_Camera_Rotation = m_Camera.FindAction("Rotation", throwIfNotFound: true);
            m_Camera_FastMovement = m_Camera.FindAction("FastMovement", throwIfNotFound: true);
            m_Camera_Movement = m_Camera.FindAction("Movement", throwIfNotFound: true);
            m_Camera_Rotate = m_Camera.FindAction("Rotate", throwIfNotFound: true);
            m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
            // Targeting
            m_Targeting = asset.FindActionMap("Targeting", throwIfNotFound: true);
            m_Targeting_SetTarget = m_Targeting.FindAction("SetTarget", throwIfNotFound: true);
            m_Targeting_Position = m_Targeting.FindAction("Position", throwIfNotFound: true);
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
        private readonly InputAction m_Selection_Select;
        private readonly InputAction m_Selection_Position;
        public struct SelectionActions
        {
            private @Control m_Wrapper;
            public SelectionActions(@Control wrapper) { m_Wrapper = wrapper; }
            public InputAction @Select => m_Wrapper.m_Selection_Select;
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
                    @Select.started -= m_Wrapper.m_SelectionActionsCallbackInterface.OnSelect;
                    @Select.performed -= m_Wrapper.m_SelectionActionsCallbackInterface.OnSelect;
                    @Select.canceled -= m_Wrapper.m_SelectionActionsCallbackInterface.OnSelect;
                    @Position.started -= m_Wrapper.m_SelectionActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_SelectionActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_SelectionActionsCallbackInterface.OnPosition;
                }
                m_Wrapper.m_SelectionActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Select.started += instance.OnSelect;
                    @Select.performed += instance.OnSelect;
                    @Select.canceled += instance.OnSelect;
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                }
            }
        }
        public SelectionActions @Selection => new SelectionActions(this);

        // Camera
        private readonly InputActionMap m_Camera;
        private ICameraActions m_CameraActionsCallbackInterface;
        private readonly InputAction m_Camera_SetFollow;
        private readonly InputAction m_Camera_ResetFollow;
        private readonly InputAction m_Camera_Position;
        private readonly InputAction m_Camera_Scroll;
        private readonly InputAction m_Camera_Drag;
        private readonly InputAction m_Camera_Rotation;
        private readonly InputAction m_Camera_FastMovement;
        private readonly InputAction m_Camera_Movement;
        private readonly InputAction m_Camera_Rotate;
        private readonly InputAction m_Camera_Zoom;
        public struct CameraActions
        {
            private @Control m_Wrapper;
            public CameraActions(@Control wrapper) { m_Wrapper = wrapper; }
            public InputAction @SetFollow => m_Wrapper.m_Camera_SetFollow;
            public InputAction @ResetFollow => m_Wrapper.m_Camera_ResetFollow;
            public InputAction @Position => m_Wrapper.m_Camera_Position;
            public InputAction @Scroll => m_Wrapper.m_Camera_Scroll;
            public InputAction @Drag => m_Wrapper.m_Camera_Drag;
            public InputAction @Rotation => m_Wrapper.m_Camera_Rotation;
            public InputAction @FastMovement => m_Wrapper.m_Camera_FastMovement;
            public InputAction @Movement => m_Wrapper.m_Camera_Movement;
            public InputAction @Rotate => m_Wrapper.m_Camera_Rotate;
            public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
            public InputActionMap Get() { return m_Wrapper.m_Camera; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
            public void SetCallbacks(ICameraActions instance)
            {
                if (m_Wrapper.m_CameraActionsCallbackInterface != null)
                {
                    @SetFollow.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnSetFollow;
                    @SetFollow.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnSetFollow;
                    @SetFollow.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnSetFollow;
                    @ResetFollow.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnResetFollow;
                    @ResetFollow.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnResetFollow;
                    @ResetFollow.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnResetFollow;
                    @Position.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnPosition;
                    @Scroll.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                    @Scroll.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                    @Scroll.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnScroll;
                    @Drag.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnDrag;
                    @Drag.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnDrag;
                    @Drag.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnDrag;
                    @Rotation.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotation;
                    @Rotation.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotation;
                    @Rotation.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotation;
                    @FastMovement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnFastMovement;
                    @FastMovement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnFastMovement;
                    @FastMovement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnFastMovement;
                    @Movement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                    @Rotate.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                    @Rotate.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                    @Rotate.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                    @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                    @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                    @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                }
                m_Wrapper.m_CameraActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @SetFollow.started += instance.OnSetFollow;
                    @SetFollow.performed += instance.OnSetFollow;
                    @SetFollow.canceled += instance.OnSetFollow;
                    @ResetFollow.started += instance.OnResetFollow;
                    @ResetFollow.performed += instance.OnResetFollow;
                    @ResetFollow.canceled += instance.OnResetFollow;
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                    @Scroll.started += instance.OnScroll;
                    @Scroll.performed += instance.OnScroll;
                    @Scroll.canceled += instance.OnScroll;
                    @Drag.started += instance.OnDrag;
                    @Drag.performed += instance.OnDrag;
                    @Drag.canceled += instance.OnDrag;
                    @Rotation.started += instance.OnRotation;
                    @Rotation.performed += instance.OnRotation;
                    @Rotation.canceled += instance.OnRotation;
                    @FastMovement.started += instance.OnFastMovement;
                    @FastMovement.performed += instance.OnFastMovement;
                    @FastMovement.canceled += instance.OnFastMovement;
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Rotate.started += instance.OnRotate;
                    @Rotate.performed += instance.OnRotate;
                    @Rotate.canceled += instance.OnRotate;
                    @Zoom.started += instance.OnZoom;
                    @Zoom.performed += instance.OnZoom;
                    @Zoom.canceled += instance.OnZoom;
                }
            }
        }
        public CameraActions @Camera => new CameraActions(this);

        // Targeting
        private readonly InputActionMap m_Targeting;
        private ITargetingActions m_TargetingActionsCallbackInterface;
        private readonly InputAction m_Targeting_SetTarget;
        private readonly InputAction m_Targeting_Position;
        public struct TargetingActions
        {
            private @Control m_Wrapper;
            public TargetingActions(@Control wrapper) { m_Wrapper = wrapper; }
            public InputAction @SetTarget => m_Wrapper.m_Targeting_SetTarget;
            public InputAction @Position => m_Wrapper.m_Targeting_Position;
            public InputActionMap Get() { return m_Wrapper.m_Targeting; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TargetingActions set) { return set.Get(); }
            public void SetCallbacks(ITargetingActions instance)
            {
                if (m_Wrapper.m_TargetingActionsCallbackInterface != null)
                {
                    @SetTarget.started -= m_Wrapper.m_TargetingActionsCallbackInterface.OnSetTarget;
                    @SetTarget.performed -= m_Wrapper.m_TargetingActionsCallbackInterface.OnSetTarget;
                    @SetTarget.canceled -= m_Wrapper.m_TargetingActionsCallbackInterface.OnSetTarget;
                    @Position.started -= m_Wrapper.m_TargetingActionsCallbackInterface.OnPosition;
                    @Position.performed -= m_Wrapper.m_TargetingActionsCallbackInterface.OnPosition;
                    @Position.canceled -= m_Wrapper.m_TargetingActionsCallbackInterface.OnPosition;
                }
                m_Wrapper.m_TargetingActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @SetTarget.started += instance.OnSetTarget;
                    @SetTarget.performed += instance.OnSetTarget;
                    @SetTarget.canceled += instance.OnSetTarget;
                    @Position.started += instance.OnPosition;
                    @Position.performed += instance.OnPosition;
                    @Position.canceled += instance.OnPosition;
                }
            }
        }
        public TargetingActions @Targeting => new TargetingActions(this);
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
            void OnSelect(InputAction.CallbackContext context);
            void OnPosition(InputAction.CallbackContext context);
        }
        public interface ICameraActions
        {
            void OnSetFollow(InputAction.CallbackContext context);
            void OnResetFollow(InputAction.CallbackContext context);
            void OnPosition(InputAction.CallbackContext context);
            void OnScroll(InputAction.CallbackContext context);
            void OnDrag(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
            void OnFastMovement(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
            void OnZoom(InputAction.CallbackContext context);
        }
        public interface ITargetingActions
        {
            void OnSetTarget(InputAction.CallbackContext context);
            void OnPosition(InputAction.CallbackContext context);
        }
    }
}
