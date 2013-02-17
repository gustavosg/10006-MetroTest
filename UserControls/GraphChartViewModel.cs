using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UserControls
{
    public class GraphChartViewModel : INotifyPropertyChanged
    {

        public GraphChartViewModel()
        {
            Titulo = "Titulo Teste";
        }

        ~GraphChartViewModel()
        {

        }

        private String titulo;
        public String Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                OnPropertyChanged("Titulo");
            }
        }

        public void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
