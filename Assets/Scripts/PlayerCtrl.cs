//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/PlayerCtrl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerCtrl: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerCtrl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCtrl"",
    ""maps"": [
        {
            ""name"": ""PlayerMvmt"",
            ""id"": ""51906f2d-b53b-4af6-87b3-7f65b4916afd"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ad76534b-381d-4b57-922c-a7a552189d98"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a4186042-14fc-49b4-8a0e-4e5c5d220665"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9bb63c41-6121-46ed-b4c5-471fa9fbd00f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""94b9e943-0edd-459f-b991-39700a70a9a1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""70f9ff23-771d-4cba-a4fb-eff1ac28a37e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c9df3e2d-a907-42c8-b6e1-74c7b9f24e7c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""d68464d4-ab8d-4eec-91f9-ff57bbf44a5b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""750205f0-edf5-44ae-b9b0-a5a174666272"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d35bbb5a-9797-4a65-988f-d9937ddcbdd3"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b91f0e97-b283-4c5d-a193-b22a289e0b28"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4622d72d-702f-4d30-ba06-2c2d61fd9be9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerAction"",
            ""id"": ""624c8800-3fce-46eb-84fd-6b4e886df496"",
            ""actions"": [
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""5bbc471b-f593-4b82-9776-34c64e9b7b79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Button"",
                    ""id"": ""57b47762-f274-4c3e-a7ae-57ea55a90d3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""916c67ae-8782-46a9-a6ed-32dc87ac4fa8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""34d08e51-3c16-4c46-abc1-e4eb58d1312b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8477cf7c-dc36-43e9-8133-f0be39ac4046"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b02aaa3c-830f-4f31-8e51-5cc2917faeeb"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""014dc01c-0b74-4e88-b11d-fc27bad0561b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMvmt
        m_PlayerMvmt = asset.FindActionMap("PlayerMvmt", throwIfNotFound: true);
        m_PlayerMvmt_movement = m_PlayerMvmt.FindAction("movement", throwIfNotFound: true);
        // PlayerAction
        m_PlayerAction = asset.FindActionMap("PlayerAction", throwIfNotFound: true);
        m_PlayerAction_Sprint = m_PlayerAction.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerAction_Walk = m_PlayerAction.FindAction("Walk", throwIfNotFound: true);
        m_PlayerAction_Jump = m_PlayerAction.FindAction("Jump", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerMvmt
    private readonly InputActionMap m_PlayerMvmt;
    private List<IPlayerMvmtActions> m_PlayerMvmtActionsCallbackInterfaces = new List<IPlayerMvmtActions>();
    private readonly InputAction m_PlayerMvmt_movement;
    public struct PlayerMvmtActions
    {
        private @PlayerCtrl m_Wrapper;
        public PlayerMvmtActions(@PlayerCtrl wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_PlayerMvmt_movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMvmt; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMvmtActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMvmtActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMvmtActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMvmtActionsCallbackInterfaces.Add(instance);
            @movement.started += instance.OnMovement;
            @movement.performed += instance.OnMovement;
            @movement.canceled += instance.OnMovement;
        }

        private void UnregisterCallbacks(IPlayerMvmtActions instance)
        {
            @movement.started -= instance.OnMovement;
            @movement.performed -= instance.OnMovement;
            @movement.canceled -= instance.OnMovement;
        }

        public void RemoveCallbacks(IPlayerMvmtActions instance)
        {
            if (m_Wrapper.m_PlayerMvmtActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMvmtActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMvmtActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMvmtActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMvmtActions @PlayerMvmt => new PlayerMvmtActions(this);

    // PlayerAction
    private readonly InputActionMap m_PlayerAction;
    private List<IPlayerActionActions> m_PlayerActionActionsCallbackInterfaces = new List<IPlayerActionActions>();
    private readonly InputAction m_PlayerAction_Sprint;
    private readonly InputAction m_PlayerAction_Walk;
    private readonly InputAction m_PlayerAction_Jump;
    public struct PlayerActionActions
    {
        private @PlayerCtrl m_Wrapper;
        public PlayerActionActions(@PlayerCtrl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Sprint => m_Wrapper.m_PlayerAction_Sprint;
        public InputAction @Walk => m_Wrapper.m_PlayerAction_Walk;
        public InputAction @Jump => m_Wrapper.m_PlayerAction_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionActionsCallbackInterfaces.Add(instance);
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Walk.started += instance.OnWalk;
            @Walk.performed += instance.OnWalk;
            @Walk.canceled += instance.OnWalk;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPlayerActionActions instance)
        {
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Walk.started -= instance.OnWalk;
            @Walk.performed -= instance.OnWalk;
            @Walk.canceled -= instance.OnWalk;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPlayerActionActions instance)
        {
            if (m_Wrapper.m_PlayerActionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionActions @PlayerAction => new PlayerActionActions(this);
    public interface IPlayerMvmtActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IPlayerActionActions
    {
        void OnSprint(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
