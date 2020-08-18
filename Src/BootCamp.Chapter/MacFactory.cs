using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory
    {
        public DesktopComputer Assemble()
        {
            var MacComputer = new DesktopComputer();

            var body = MacComputer.GetBody();
            var motherboard = MacComputer.GetMotherboard();
            var cpu = MacComputer.GetCpu();
            var ram = MacComputer.GetRam();
            var harddrive = MacComputer.GetHard();
            var gpu = MacComputer.GetGpu();
            

            



            return new DesktopComputer();
        }
    }
}
