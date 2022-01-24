// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""80aa9c46-c189-4e42-8560-ea704eeee1bb"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""69338294-bbd2-411b-a9c3-8b2d8bc8990e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walking"",
                    ""type"": ""Value"",
                    ""id"": ""82a3a9bc-3f24-4ccc-88a3-b20056b1776c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lateral L"",
                    ""type"": ""Value"",
                    ""id"": ""29c65f25-4616-4256-b90e-a66ef6076b8f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lateral R"",
                    ""type"": ""Value"",
                    ""id"": ""8c5fb20e-80a2-4342-9900-1c860f3fab5c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Saltar"",
                    ""type"": ""Button"",
                    ""id"": ""5bed8e25-cdb7-4abb-bce5-1af4eea84ddc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""5fe0fdcd-60f3-48d0-869f-081eb9ca3be7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""ad625541-5f3c-4673-ad61-e57212525c6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06af6572-afa8-403e-995d-3dbaa57fa8d8"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5dc7e56-def5-4a0f-9e0e-8f6b8ce57b64"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66f0b842-c630-4dc2-bc5f-a99fa22dc05c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lateral L"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee2f464d-ccda-44d4-bf0c-d6688fcc664b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lateral R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5463d172-85ed-4dcc-be9d-dd117523d7c1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dbad02c-4ccf-4b4a-a3f4-6354ea24421b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a971dc9-c38d-41ed-81a5-2413e7046a08"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""8fd8caa2-96c8-4c80-aa29-a88ea294da8c"",
            ""actions"": [
                {
                    ""name"": ""Pivot"",
                    ""type"": ""Value"",
                    ""id"": ""8429692c-b5c5-47a9-9813-3ce66501453c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6b3fc018-5bf0-4b7f-b087-1aaa25a07506"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pivot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Run = m_Move.FindAction("Run", throwIfNotFound: true);
        m_Move_Walking = m_Move.FindAction("Walking", throwIfNotFound: true);
        m_Move_LateralL = m_Move.FindAction("Lateral L", throwIfNotFound: true);
        m_Move_LateralR = m_Move.FindAction("Lateral R", throwIfNotFound: true);
        m_Move_Saltar = m_Move.FindAction("Saltar", throwIfNotFound: true);
        m_Move_Apuntar = m_Move.FindAction("Apuntar", throwIfNotFound: true);
        m_Move_Disparar = m_Move.FindAction("Disparar", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Pivot = m_Camera.FindAction("Pivot", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Run;
    private readonly InputAction m_Move_Walking;
    private readonly InputAction m_Move_LateralL;
    private readonly InputAction m_Move_LateralR;
    private readonly InputAction m_Move_Saltar;
    private readonly InputAction m_Move_Apuntar;
    private readonly InputAction m_Move_Disparar;
    public struct MoveActions
    {
        private @InputController m_Wrapper;
        public MoveActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_Move_Run;
        public InputAction @Walking => m_Wrapper.m_Move_Walking;
        public InputAction @LateralL => m_Wrapper.m_Move_LateralL;
        public InputAction @LateralR => m_Wrapper.m_Move_LateralR;
        public InputAction @Saltar => m_Wrapper.m_Move_Saltar;
        public InputAction @Apuntar => m_Wrapper.m_Move_Apuntar;
        public InputAction @Disparar => m_Wrapper.m_Move_Disparar;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Run.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnRun;
                @Walking.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnWalking;
                @Walking.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnWalking;
                @Walking.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnWalking;
                @LateralL.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnLateralL;
                @LateralL.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnLateralL;
                @LateralL.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnLateralL;
                @LateralR.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnLateralR;
                @LateralR.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnLateralR;
                @LateralR.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnLateralR;
                @Saltar.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnSaltar;
                @Saltar.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnSaltar;
                @Saltar.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnSaltar;
                @Apuntar.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnApuntar;
                @Apuntar.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnApuntar;
                @Apuntar.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnApuntar;
                @Disparar.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnDisparar;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Walking.started += instance.OnWalking;
                @Walking.performed += instance.OnWalking;
                @Walking.canceled += instance.OnWalking;
                @LateralL.started += instance.OnLateralL;
                @LateralL.performed += instance.OnLateralL;
                @LateralL.canceled += instance.OnLateralL;
                @LateralR.started += instance.OnLateralR;
                @LateralR.performed += instance.OnLateralR;
                @LateralR.canceled += instance.OnLateralR;
                @Saltar.started += instance.OnSaltar;
                @Saltar.performed += instance.OnSaltar;
                @Saltar.canceled += instance.OnSaltar;
                @Apuntar.started += instance.OnApuntar;
                @Apuntar.performed += instance.OnApuntar;
                @Apuntar.canceled += instance.OnApuntar;
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Pivot;
    public struct CameraActions
    {
        private @InputController m_Wrapper;
        public CameraActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pivot => m_Wrapper.m_Camera_Pivot;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Pivot.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnPivot;
                @Pivot.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnPivot;
                @Pivot.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnPivot;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pivot.started += instance.OnPivot;
                @Pivot.performed += instance.OnPivot;
                @Pivot.canceled += instance.OnPivot;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IMoveActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnWalking(InputAction.CallbackContext context);
        void OnLateralL(InputAction.CallbackContext context);
        void OnLateralR(InputAction.CallbackContext context);
        void OnSaltar(InputAction.CallbackContext context);
        void OnApuntar(InputAction.CallbackContext context);
        void OnDisparar(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnPivot(InputAction.CallbackContext context);
    }
}
