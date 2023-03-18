using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Footsies
{
    public class InputManager : Singleton<InputManager>
    {
        public enum Command
        {   
            vsAiLeft,
            vsAiRight,
            vsAiAttack,
            p2Left,
            p2Right,
            p2Attack,
            cancel,
        }

        public enum PadMenuInputState
        {
            Up,
            Down,
            Confirm,
        }

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        private void Update()
        {
        }
        
        //TODO left side of vita is p1 right side is p2
        public bool GetButton(Command command)
        {
            return Input.GetButton(GetInputName(command));
        }

        public bool GetButtonDown(Command command)
        {
            return Input.GetButtonDown(GetInputName(command));
        }

        public bool GetButtonUp(Command command)
        {
            return Input.GetButtonUp(GetInputName(command));
        }

        private string GetInputName(Command command)
        {
            switch(command)
            {
                case Command.vsAiLeft:
                    return "Vs_Ai_Left";
                case Command.vsAiRight:
                    return "Vs_Ai_Right";
               case Command.vsAiAttack:
                    return "Vs_Ai_Attack";
                case Command.p2Left:
                    return "P2_Left";
              case Command.p2Right:
                  return "P2_Right";
               case Command.p2Attack:
                    return "P2_Attack";
                case Command.cancel:
                    return "Cancel";
            }
            
            return "";
        }
    }
}