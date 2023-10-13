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
            estudiantes.Add(new Estudiante { DisplayName = "Sección A" });
            estudiantes.Add(new Estudiante { DisplayName = "Sección B" });
            estudiantes.Add(new Estudiante { DisplayName = "Sección C " });


        }
    }
    }