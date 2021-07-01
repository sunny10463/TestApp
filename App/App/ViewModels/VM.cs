using App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App.ViewModels
{
    public class VM : ViewModelBase
    {
        private ObservableCollection<Model> _List = new ObservableCollection<Model>();
        public ObservableCollection<Model> List
        {
            get
            {
                return _List;
            }
            set
            {
                _List = value;
            }
        }
    }
}