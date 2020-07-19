using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on;
        private int _volume = 0;

        public Radio()
        {

        }

        public int Channel
        {
            get { return _channel; }
            set
            {
                if (_on == true && value >= 1 && value <= 4)
                {
                    _channel = value;
                }
            }
        }


        public string Play()
        {
            if (_on == true)
            {
                return ($"Playing channel {_channel}");
            }
            else return "Radio is off";

        }

        public void TurnOff()
        {
            _on = false;
        }

        public void TurnOn()
        {
            _on = true;
        }
        
        public int IncreaseVolume()
        {
            _volume++;
            return _volume;
        }

        public int DecreaseVolume()
        {

            _volume--;
            return _volume;
        }
    }
}

    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
