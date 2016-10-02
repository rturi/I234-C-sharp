using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prax1
{
    class MotorVehicle
    {

        protected int _speed = 0;
        protected int _maxSpeed = 20;

        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

        public MotorVehicle(int maxSpeed)
        {
            _maxSpeed = maxSpeed;
        }

        public virtual void accelerate()
        {
            Speed += 10;
            if (Speed > _maxSpeed) Speed = _maxSpeed;
        }


        public void stop()
        {
            _speed = 0;
        }

        public string currentState()
        {
            if (_speed == 0) return "the vehicle is not moving";
            else return "vehicle's speed is " + _speed;
        }

        public override string ToString()
        {
            return currentState();
        }

    }

    class Car:MotorVehicle
    {
        private bool areDoorsOpen;

        public Car():base(100)
        {
            areDoorsOpen = false;
        }


        public void openDoors()
        {
            if (Speed != 0) Speed = 0;
            areDoorsOpen = true;
        }

        public void closeDoors()
        {
            areDoorsOpen = false;
        }

        public override void accelerate()
        {
            if (areDoorsOpen)
            {
                _speed = 0;
                return;
            }
            base.accelerate();
        }

        public override string ToString()
        {
            string answer = base.ToString();

            if (areDoorsOpen) answer += " and the doors are open";
            else answer += " and the doors are closed";

            return answer;
        }

    }

    class DumpTruck:Car
    {

    private bool _isDipping = false;

        public DumpTruck()
        {
            _maxSpeed = 70;
        }

        public void startDipping()
        {
            _isDipping = true;
        }

        public override void accelerate()
        {
            if (_isDipping)
            {
                _speed = 0;
                return;
            }
            base.accelerate();
        }

        public override string ToString()
        {
            string answer = base.ToString();

            if (_isDipping) answer += " and the the truck is dumping";
            else answer += " and the truck is not dumping";

            return answer;
        }
    }


    class MotorVehicleTest
    {
       public MotorVehicleTest()
        {
            MotorVehicle a = new MotorVehicle(15);
            MotorVehicle b = new MotorVehicle(50);

            Console.WriteLine("created new motor vehicles:\n a (15)\n b (50)");
            a.accelerate();
            a.accelerate();
            Console.WriteLine("a's speed after two accelerations is " + a.Speed);
            b.accelerate();
            b.accelerate();
            Console.WriteLine("b's speed after two accelerations is " + b.Speed);
            a.stop();
            Console.WriteLine("a's speed after stop command is " + a.Speed);
            Console.WriteLine("b's current status is: " + b);

            Car c = new Car();

            Console.WriteLine("created new car: c");
            c.accelerate();
            Console.WriteLine("c's status after acceleration: " + c.ToString());
            c.openDoors();
            c.accelerate();
            Console.WriteLine("c's status after opening doors and accelrating: " + c.ToString());

            DumpTruck d = new DumpTruck();

            Console.WriteLine("created new car: d");
            d.accelerate();
            Console.WriteLine("d's status after acceleration: " + d.ToString());
            d.startDipping();
            d.accelerate();
            Console.WriteLine("d's status after startDipping and accelrating: " + d.ToString());

        }
    }

}
