// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerActionControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionControls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""45712029-e6c3-4836-bb2d-6ba2b01c2eb2"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""d88d8318-a974-41f6-86c4-4b1ffa4b571e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""7be95ed1-6af1-4b0d-a8fd-d0be3a93e382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0d1dbe1e-5ab9-4064-b771-0945d364b092"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""adda0dd5-cc0a-44b1-9cae-9ed4e5090a7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5cee2b9e-dd87-43cf-95ae-c8a0be5c83b9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""04d212a0-9d9a-4742-add8-d5b014d0a650"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerActions"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""864fd644-9071-479c-a84e-40dd1f7794ae"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerActions"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""90ddcd89-2e67-4e2a-81f7-1974c675a6f5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fc7e20ca-d944-4f9d-a5ce-112b54d01238"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerActions"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""876fa131-91d7-4b9c-9b79-8580177ca3e2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerActions"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e5ace345-3ee8-468e-af33-de716308ff14"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerActions"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3eee71f9-830a-4a64-9171-efb1ffaf1748"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerActions"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9e91be1-c5ac-45b4-85b8-0c2451664878"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerActions"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PlayerActions"",
            ""bindingGroup"": ""PlayerActions"",
            ""devices"": []
        }
    ]
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Horizontal = m_Land.FindAction("Horizontal", throwIfNotFound: true);
        m_Land_Vertical = m_Land.FindAction("Vertical", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_Attack = m_Land.FindAction("Attack", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Horizontal;
    private readonly InputAction m_Land_Vertical;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Attack;
    public struct LandActions
    {
        private @PlayerActionControls m_Wrapper;
        public LandActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Land_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Land_Vertical;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Attack => m_Wrapper.m_Land_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_LandActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_LandActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnVertical;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    private int m_PlayerActionsSchemeIndex = -1;
    public InputControlScheme PlayerActionsScheme
    {
        get
        {
            if (m_PlayerActionsSchemeIndex == -1) m_PlayerActionsSchemeIndex = asset.FindControlSchemeIndex("PlayerActions");
            return asset.controlSchemes[m_PlayerActionsSchemeIndex];
        }
    }
    public interface ILandActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
