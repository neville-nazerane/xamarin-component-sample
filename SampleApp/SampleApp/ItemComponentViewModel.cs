using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SampleApp
{
    public class ItemComponentViewModel : INotifyPropertyChanged
    {
        private Item data;

        public event PropertyChangedEventHandler PropertyChanged;

        public Item Data
        {
            get => data;
            set
            {
                data = value;
                Changed();
            }
        }

        void Changed([CallerMemberName]string propertyName = "")
            => PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

    }
}
