using FreshMvvm;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.PageModels
{
    public class HomePageModel: FreshBasePageModel
    {
        private string _name;
        public string Name
        {
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
            get
            {
                return _name;
            }
        }
        public override void Init(object initData)
        {
            Name = initData.ToString();
        }
    }
}
