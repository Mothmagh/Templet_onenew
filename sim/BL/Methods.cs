﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace sim.BL
{
    internal class Methods
    {
       public MemoryStream ma = new MemoryStream();
        public byte[] by;
        //convert to byte
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }
        //COVERT BYTE TO IMAGE
        public MemoryStream convert_image()
        {
            ma=new MemoryStream(by);
            return ma;
        }
    }
}
