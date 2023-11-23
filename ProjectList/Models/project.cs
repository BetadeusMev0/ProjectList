using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectList.Models 
{
    public class Project : INotifyPropertyChanged
    {
        protected string _name; 
        protected string _description;
        protected DateTime _startDate;
        protected DateTime _endDate;

        public ObservableCollection<PTask> Tasks = new();



        public string Name { get { return _name;}  set { _name = value; OnPropertyChanged("Name"); } }
        public string Description { get { return _description; } set { _description = value; OnPropertyChanged("Description"); } }

        public DateTime StartDate { get { return _startDate;}
            set
            {
                _startDate = value;
                OnPropertyChanged();
            } }

        public DateTime EndDate { get { return _endDate;}
            set
            {
                _endDate = value;
                OnPropertyChanged();
            } }

        public Project(string name, string description, DateTime startDate, DateTime endDate) 
        {
            _name= name;
            _description= description;
            _startDate= startDate;
            _endDate= endDate;
        }

        public PCommands TestCommand 
        {
            get 
            {
                return new PCommands((obj) =>
                {
                    (((ObservableCollection<Project>)((ListView)obj).ItemsSource)).Remove(this);
                });
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
    




}
