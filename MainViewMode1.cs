using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Test
{
    public class MainViewMode1 : INotifyPropertyChanged
    {
        public MainViewMode1()
        {
            Name = "hhh";
            Task.Run(async() =>
            {
                await Task.Delay(1000);//时间间隔
                Name = "qq";//操作内容
            });
            
        }

        private string name;
        public string Name { get { return name; }
            set { name = value;
                OnPropertyChanged("Name");
            } }
        
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected void OnPropertyChanged(string properName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(properName));
            }
        }
    }
}
