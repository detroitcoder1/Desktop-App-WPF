using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace AdPosterLibrary.Model
{
    public class User : INotifyPropertyChanged
    {
        private string _name;
        private string _phoneNumber;
        private string _location;
        private string _state;
        private string _remarks;

        private string _remarks2;
        private string _info;

        [field: NonSerialized()]
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string _name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        public string Remarks2
        {
            get { return _remarks2; }
            set { _remarks2 = value; }
        }
        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public User(string name, string phoneNumber, string Location, string State, string Remarks, string Remarks2, string Info)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _location = Location;
            _state = State;
            _remarks = Remarks;
            _remarks2 = Remarks2;
            _info = Info;
        }

        public User()
        {
        }
    }
}
