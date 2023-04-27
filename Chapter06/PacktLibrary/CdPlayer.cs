using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary
{
    public class CdPlayer : IPlayable
    {
        public void Play()
        {
            WriteLine("CD is playing!");
        }

        public void Pause()
        {
            WriteLine("CD is on pause!");

        }
    }
}
