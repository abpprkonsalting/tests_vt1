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
        private DateTime _startWorkingHours = DateTime.ParseExact("08:00", "HH:mm", CultureInfo.InvariantCulture);
        private DateTime _endWorkingHours = DateTime.ParseExact("18:00", "HH:mm", CultureInfo.InvariantCulture);
        private TimeSpan _extraStart;
        private TimeSpan _extraEnd;
        public TimeSpan worked;
        public TimeSpan extra;

        public string StartTime { 
            get { 
                return _startTime.ToString();
            } 
            set {
                var start = DateTime.ParseExact(value, "HH:mm", CultureInfo.InvariantCulture);
                var extraStart = _startWorkingHours - start;
                _extraStart = extraStart.Ticks > 0 ? extraStart : new TimeSpan(0);
                _startTime = extraStart.Ticks >= 0 ? _startWorkingHours : _startWorkingHours - extraStart;
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
                var end = DateTime.ParseExact(value, "HH:mm", CultureInfo.InvariantCulture);
                var extraEnd = end - _endWorkingHours;
                _extraEnd = extraEnd.Ticks > 0 ? extraEnd : new TimeSpan(0);
                _endTime = extraEnd.Ticks >= 0 ? _endWorkingHours : _endWorkingHours + extraEnd;
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

        public int calculateSalary()
        {
            worked = _endTime - _startTime;
            extra = _extraStart + _extraEnd;
            return Convert.ToInt32((worked.TotalHours * this._hourRate) + 
                    ((extra.TotalHours * this._hourRate) * this._extraHourFactor));

        }
    }
}
