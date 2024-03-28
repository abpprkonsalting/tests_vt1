using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsVT
{
    internal class SalaryCalculator
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private int _hourRate;
        private int _extraHourFactor;

        public string StartTime { 
            get { 
                return _startTime.ToString();
            } 
            set {
                _startTime = DateTime.ParseExact(value, "HH:mm", CultureInfo.InvariantCulture);
            } 
        }

        public string EndTime
        {
            get
            {
                return _endTime.ToString();
            }
            set
            {
                _endTime = DateTime.ParseExact(value, "HH:mm", CultureInfo.InvariantCulture);
            }
        }

        public string HourRate
        {
            get
            {
                return _hourRate.ToString();
            }
            set { 
                this._hourRate = Convert.ToInt32(value);
            }
        }

        public string ExtraHourFactor
        {
            get
            {
                return _extraHourFactor.ToString();
            }
            set
            {
                this._extraHourFactor = Convert.ToInt32(value);
            }
        }
    }
}
