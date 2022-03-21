using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfPetarShatanovski.Infrastructure
{
    public class NotificationClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        /// <summary>
        /// CallerMemberName lives in System.Runtime.CompilerServices
        /// </summary>
        /// <param name="propertyName"></param>

        public void OnProprtyChanged([CallerMemberName]string propertyName = null)
        {
            //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
