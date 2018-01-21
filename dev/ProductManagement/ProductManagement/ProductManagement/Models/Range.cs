using ProductManagement.Framework;

namespace ProductManagement.Models
{
    public class Range : BasePropertyChange
    {
        private int _rangeId;

        public int RangeId
        {
            get => _rangeId;
            set
            {
                if (_rangeId != value)
                {
                    _rangeId = value;
                    RaisePropertyChanged(nameof(RangeId));
                }
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }
    }
}