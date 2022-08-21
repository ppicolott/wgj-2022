//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Scripts/InputSystem/Controller.inputactions
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

public partial class @Controllers : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Scenario"",
            ""id"": ""022dc1f4-aaef-4e7a-853e-9c7c30a245f5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d91d527f-9145-4e22-aafb-994cd6a04844"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f4987a20-e747-4576-ba06-4329024391bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4a0be1ed-6b62-42dd-a2ac-d87bd39e6dd1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e6650ea-3b74-4f13-bb58-ef2eb738a4d6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1bfd8f8-41fd-4525-8a42-5e78ec9aa64a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a11c4af7-1102-4bf4-b12d-40ea8366ce92"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fce8151-654f-425b-af4e-ccd149bd09c0"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9dd1b7b-1ae2-4092-8dbf-9c5ab7f71ac9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Scenario
        m_Scenario = asset.FindActionMap("Scenario", throwIfNotFound: true);
        m_Scenario_Move = m_Scenario.FindAction("Move", throwIfNotFound: true);
        m_Scenario_Rotate = m_Scenario.FindAction("Rotate", throwIfNotFound: true);
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

    // Scenario
    private readonly InputActionMap m_Scenario;
    private IScenarioActions m_ScenarioActionsCallbackInterface;
    private readonly InputAction m_Scenario_Move;
    private readonly InputAction m_Scenario_Rotate;
    public struct ScenarioActions
    {
        private @Controllers m_Wrapper;
        public ScenarioActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Scenario_Move;
        public InputAction @Rotate => m_Wrapper.m_Scenario_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Scenario; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ScenarioActions set) { return set.Get(); }
        public void SetCallbacks(IScenarioActions instance)
        {
            if (m_Wrapper.m_ScenarioActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ScenarioActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ScenarioActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ScenarioActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_ScenarioActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_ScenarioActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_ScenarioActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_ScenarioActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public ScenarioActions @Scenario => new ScenarioActions(this);
    public interface IScenarioActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
