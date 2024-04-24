using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Prac2.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private byte _redValue;
        private byte _greenValue;
        private byte _blueValue;
        private SolidColorBrush _displayColor;

        public byte RedValue
        {
            get { return _redValue; }
            set
            {
                _redValue = value;
                UpdateColor();
            }
        }

        public byte GreenValue
        {
            get { return _greenValue; }
            set
            {
                _greenValue = value;
                UpdateColor();
            }
        }

        public byte BlueValue
        {
            get { return _blueValue; }
            set
            {
                _blueValue = value;
                UpdateColor();
            }
        }

        public SolidColorBrush DisplayColor
        {
            get { return _displayColor; }
            set
            {
                _displayColor = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            RedValue = 255;
            GreenValue = 255;
            BlueValue = 255;
            UpdateColor();
        }

        private void UpdateColor()
        {
            DisplayColor = new SolidColorBrush(Color.FromRgb(RedValue, GreenValue, BlueValue));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
