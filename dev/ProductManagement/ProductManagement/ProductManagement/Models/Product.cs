using ProductManagement.Framework;

namespace ProductManagement.Models
{
    public class Product : BasePropertyChange
    {
        private string _code;

        public string Code
        {
            get => _code;
            set
            {
                if (_code != value)
                {
                    _code = value;
                    RaisePropertyChanged(nameof(Code));
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

       // private int _rangeId;

        //public int RangeId
        //{
        //    get => _rangeId;
        //    set
        //    {
        //        if (_rangeId != value)
        //        {
        //            _rangeId = value;
        //            RaisePropertyChanged(nameof(RangeId));
        //        }
        //    }
        //}

        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    RaisePropertyChanged(nameof(Price));
                }
            }
        }

        //private Range _range;

        //public virtual Range Range
        //{
        //    get => _range;
        //    set
        //    {
        //        if (_range != value)
        //        {
        //            _range = value;
        //            RaisePropertyChanged(nameof(Range));
        //        }
        //    }
        //}

    }
}