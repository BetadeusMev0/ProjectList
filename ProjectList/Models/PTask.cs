using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Models
{
    public class PTask : INotifyPropertyChanged
    {
        private int _id;

        private string _name;
        private string _description;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged("Id"); } }
        public string Name { get { return _name; } set { _description = value; OnPropertyChanged("Name"); } }
        public string Description { get { return _description;} set { _description = value; OnPropertyChanged("Description"); } }





        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
