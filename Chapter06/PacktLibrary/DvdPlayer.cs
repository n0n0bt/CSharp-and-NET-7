using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class DvdPlayer : IPlayable
{
    public void Play()
    {
        WriteLine("Dvd is playing!");
    }

    public void Pause()
    {
        WriteLine("Dvd is on pause!");
       
    }
}
