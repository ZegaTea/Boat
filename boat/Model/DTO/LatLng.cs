using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat.Model.DTO
{
    class LatLng
    {
        public LatLng(double vido, double kinhdo)
        {
            this.vido = vido;
            this.kinhdo = kinhdo;
        }

        public LatLng()
        {
        }

        public double vido { get; set; }
        public double kinhdo { get; set; }
    }
}
