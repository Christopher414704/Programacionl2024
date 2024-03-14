using System;

namespace SuperficieFrontal
{

    public class Formas()
    {
        public double Alto { get; set; }
        public double Largo { get; set; }

        public double SuperficieFrontal1 => Alto * Largo;
    }


}
