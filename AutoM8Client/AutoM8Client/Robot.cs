using System;
using System.Collections.Generic;
using System.Text;

using WindowsInput.Native;
using WindowsInput;

namespace AutoM8Client
{
    class Robot
    {
        InputSimulator sim = new InputSimulator();

        public void type(String s)
        {
            sim.Keyboard.TextEntry(s);
        }
    }
}
