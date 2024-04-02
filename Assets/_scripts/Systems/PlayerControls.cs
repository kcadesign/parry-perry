//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""5facc8c5-2cc4-422a-8e0d-0780def3ed6e"",
            ""actions"": [
                {
                    ""name"": ""Rolling"",
                    ""type"": ""Value"",
                    ""id"": ""492248a7-5b88-4541-bfc4-6e19b1ad1788"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Parry"",
                    ""type"": ""Button"",
                    ""id"": ""12899ac5-4934-4aae-921b-d1d12e8ff43d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""a2a02bab-e4c8-4184-b8dd-0da074379564"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""2f66ea4d-1e3a-44fb-95c9-6781000d06c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateFriend"",
                    ""type"": ""Button"",
                    ""id"": ""90f67c6b-0652-4f29-a98e-f5d71cf18b25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropDown"",
                    ""type"": ""Button"",
                    ""id"": ""a1e99f69-349a-4c54-9548-b7c53e629670"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""de921c7a-ed83-4f8f-a1e0-2689253f8cc1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""507dfc10-256f-445f-98f1-7d6ff8db43d8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bb5ec83e-9a30-4fbe-aced-8d699523a5ca"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""02dba59b-5e29-4304-9f0e-b39e66c52783"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bfbdf9fb-9cfa-4a68-bdd1-f9bb06c2f498"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""db4b7bda-355f-496d-a0f5-9d5b6d3a3326"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""926ddf5e-e3fb-421e-aa2b-d3999dc4a799"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0619f30f-22fb-4223-8a1b-8dc1a7a998e9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8135f3ac-0092-4c39-b45e-0298508b1a63"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8c28eb5c-2978-403b-9bff-43ca43986657"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d722f99e-4144-42f3-b078-e92230f319d3"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rolling"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6947b77-8e90-47bf-9186-a097147f8f86"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b97a406-3307-4c31-8fde-bafdae71c24b"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4487b11-7dad-4906-9aa0-89f106be3947"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateFriend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb4a2589-c931-4b0b-81ed-069423db3a19"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateFriend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""010f2e7d-98a8-4ea8-8268-00166e28e2d8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de358faa-5c05-4c8d-aee2-83687f25e136"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fdbdbd8-9e9c-4913-b3b0-ebe2a2944b72"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03c577e4-7caf-4145-afbf-70cda920bf07"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f05a70e3-b763-4a5f-bce3-0f5783cb5eb1"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2af3c01d-de24-4dd9-98c9-0fb1d53a3f8e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef6b9731-f57e-4e08-be84-43e6514a6ed2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""2430884e-8677-4709-983c-d9187363e20d"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""fe636b82-a606-4fd4-8d2d-cd183a8422b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa6d93f9-5c16-44de-a3c9-a35e4c4a9afa"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""521a05a6-eb40-4a95-90f1-f10e29417437"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Intro"",
            ""id"": ""72e2553a-bffa-440d-8a14-8907b4a4bca3"",
            ""actions"": [
                {
                    ""name"": ""NextScene"",
                    ""type"": ""Button"",
                    ""id"": ""0df70d04-b57c-43a7-a261-1ceae6e25f1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2876c3c9-0d01-4b02-a62c-fc05e5947e6f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Rolling = m_Gameplay.FindAction("Rolling", throwIfNotFound: true);
        m_Gameplay_Parry = m_Gameplay.FindAction("Parry", throwIfNotFound: true);
        m_Gameplay_Block = m_Gameplay.FindAction("Block", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_ActivateFriend = m_Gameplay.FindAction("ActivateFriend", throwIfNotFound: true);
        m_Gameplay_DropDown = m_Gameplay.FindAction("DropDown", throwIfNotFound: true);
        // Menus
        m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
        m_Menus_Pause = m_Menus.FindAction("Pause", throwIfNotFound: true);
        // Intro
        m_Intro = asset.FindActionMap("Intro", throwIfNotFound: true);
        m_Intro_NextScene = m_Intro.FindAction("NextScene", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Rolling;
    private readonly InputAction m_Gameplay_Parry;
    private readonly InputAction m_Gameplay_Block;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_ActivateFriend;
    private readonly InputAction m_Gameplay_DropDown;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rolling => m_Wrapper.m_Gameplay_Rolling;
        public InputAction @Parry => m_Wrapper.m_Gameplay_Parry;
        public InputAction @Block => m_Wrapper.m_Gameplay_Block;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @ActivateFriend => m_Wrapper.m_Gameplay_ActivateFriend;
        public InputAction @DropDown => m_Wrapper.m_Gameplay_DropDown;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Rolling.started += instance.OnRolling;
            @Rolling.performed += instance.OnRolling;
            @Rolling.canceled += instance.OnRolling;
            @Parry.started += instance.OnParry;
            @Parry.performed += instance.OnParry;
            @Parry.canceled += instance.OnParry;
            @Block.started += instance.OnBlock;
            @Block.performed += instance.OnBlock;
            @Block.canceled += instance.OnBlock;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @ActivateFriend.started += instance.OnActivateFriend;
            @ActivateFriend.performed += instance.OnActivateFriend;
            @ActivateFriend.canceled += instance.OnActivateFriend;
            @DropDown.started += instance.OnDropDown;
            @DropDown.performed += instance.OnDropDown;
            @DropDown.canceled += instance.OnDropDown;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Rolling.started -= instance.OnRolling;
            @Rolling.performed -= instance.OnRolling;
            @Rolling.canceled -= instance.OnRolling;
            @Parry.started -= instance.OnParry;
            @Parry.performed -= instance.OnParry;
            @Parry.canceled -= instance.OnParry;
            @Block.started -= instance.OnBlock;
            @Block.performed -= instance.OnBlock;
            @Block.canceled -= instance.OnBlock;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @ActivateFriend.started -= instance.OnActivateFriend;
            @ActivateFriend.performed -= instance.OnActivateFriend;
            @ActivateFriend.canceled -= instance.OnActivateFriend;
            @DropDown.started -= instance.OnDropDown;
            @DropDown.performed -= instance.OnDropDown;
            @DropDown.canceled -= instance.OnDropDown;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menus
    private readonly InputActionMap m_Menus;
    private List<IMenusActions> m_MenusActionsCallbackInterfaces = new List<IMenusActions>();
    private readonly InputAction m_Menus_Pause;
    public struct MenusActions
    {
        private @PlayerControls m_Wrapper;
        public MenusActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Menus_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Menus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
        public void AddCallbacks(IMenusActions instance)
        {
            if (instance == null || m_Wrapper.m_MenusActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenusActionsCallbackInterfaces.Add(instance);
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IMenusActions instance)
        {
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IMenusActions instance)
        {
            if (m_Wrapper.m_MenusActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenusActions instance)
        {
            foreach (var item in m_Wrapper.m_MenusActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenusActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenusActions @Menus => new MenusActions(this);

    // Intro
    private readonly InputActionMap m_Intro;
    private List<IIntroActions> m_IntroActionsCallbackInterfaces = new List<IIntroActions>();
    private readonly InputAction m_Intro_NextScene;
    public struct IntroActions
    {
        private @PlayerControls m_Wrapper;
        public IntroActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextScene => m_Wrapper.m_Intro_NextScene;
        public InputActionMap Get() { return m_Wrapper.m_Intro; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IntroActions set) { return set.Get(); }
        public void AddCallbacks(IIntroActions instance)
        {
            if (instance == null || m_Wrapper.m_IntroActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_IntroActionsCallbackInterfaces.Add(instance);
            @NextScene.started += instance.OnNextScene;
            @NextScene.performed += instance.OnNextScene;
            @NextScene.canceled += instance.OnNextScene;
        }

        private void UnregisterCallbacks(IIntroActions instance)
        {
            @NextScene.started -= instance.OnNextScene;
            @NextScene.performed -= instance.OnNextScene;
            @NextScene.canceled -= instance.OnNextScene;
        }

        public void RemoveCallbacks(IIntroActions instance)
        {
            if (m_Wrapper.m_IntroActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IIntroActions instance)
        {
            foreach (var item in m_Wrapper.m_IntroActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_IntroActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public IntroActions @Intro => new IntroActions(this);
    public interface IGameplayActions
    {
        void OnRolling(InputAction.CallbackContext context);
        void OnParry(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnActivateFriend(InputAction.CallbackContext context);
        void OnDropDown(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IIntroActions
    {
        void OnNextScene(InputAction.CallbackContext context);
    }
}
