using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_ToolBox
{
    [Flags]
    enum DirectXKeys : uint
    {
        Escape = 0x01,
        M = 0x32,
        KeyDown = 0xD0,
        Enter = 0x1C,
        ArrowUp = 0xC8,
        ArrowRight = 0xCD
    }
}
