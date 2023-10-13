using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<Estudiante> estudiantes = new ObservableCollection<Estudiante>();

        public ObservableCollection<Estudiante> Estudiantes { get { return estudiantes; } }

        public ListViewGroup()
        {
            InitializeComponent();
            EstudianteView.ItemsSource = estudiantes;
            estudiantes.Add(new Estudiante { DisplayName = "Rob Finnerty" });
            estudiantes.Add(new Estudiante { DisplayName = "Bill Wrestler" });
            estudiantes.Add(new Estudiante { DisplayName = "Dr. Geri-Beth Hooper " });
            estudiantes.Add(new Estudiante { DisplayName = "Dr.Keith Joyce-Purdy" });
            estudiantes.Add(new Estudiante { DisplayName = "Sheri Spruce" });
            estudiantes.Add(new Estudiante { DisplayName = "Burt Indybrick" });

        }
    }
    }S