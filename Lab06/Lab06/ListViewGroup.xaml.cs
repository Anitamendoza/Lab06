using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Lab06
{
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();

            var groupA = new EstudianteGroup("Sección A");
            var groupB = new EstudianteGroup("Sección B");
            var groupC = new EstudianteGroup("Sección C");

            // Agregar tres alumnos con nombres y apellidos diferentes a la Sección A
            groupA.Add(new Estudiante
            {
                Nombres = "Ana",
                Apellidos = "Mendoza",
                Edad = 20
            });
            groupA.Add(new Estudiante
            {
                Nombres = "Cristina",
                Apellidos = "Cordova",
                Edad = 22
            });
            groupA.Add(new Estudiante
            {
                Nombres = "Pamela",
                Apellidos = "Martínez",
                Edad = 19
            });

            // Agregar cuatro alumnos con nombres y apellidos diferentes a la Sección B
            groupB.Add(new Estudiante
            {
                Nombres = "Delia",
                Apellidos = "Llamuco",
                Edad = 21
            });
            groupB.Add(new Estudiante
            {
                Nombres = "Giane",
                Apellidos = "Uscamayta",
                Edad = 23
            });
            groupB.Add(new Estudiante
            {
                Nombres = "Anny",
                Apellidos = "Landeon",
                Edad = 20
            });
            groupB.Add(new Estudiante
            {
                Nombres = "Rossy",
                Apellidos = "Vasquez",
                Edad = 24
            });

            // Agregar cinco alumnos con nombres y apellidos diferentes a la Sección C
            groupC.Add(new Estudiante
            {
                Nombres = "Eduardo",
                Apellidos = "Mendoza",
                Edad = 22
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Moises",
                Apellidos = "Torres",
                Edad = 23
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Sarai",
                Apellidos = "Hernández",
                Edad = 19
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Fernando",
                Apellidos = "Pérez",
                Edad = 21
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Jhonny",
                Apellidos = "Chanco",
                Edad = 20
            });

            var gruposDeEstudiantes = new List<EstudianteGroup> { groupA, groupB, groupC };
            var collectionView = new CollectionView
            {
                IsGrouped = true,
                ItemsSource = gruposDeEstudiantes,
                GroupHeaderTemplate = new DataTemplate(() =>
                {
                    var label = new Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        TextColor = Color.White
                    };
                    label.SetBinding(Label.TextProperty, "Nombre");
                    return new StackLayout
                    {
                        BackgroundColor = Color.Purple,
                        Padding = new Thickness(10),
                        Children = { label }
                    };
                }),
                ItemTemplate = new DataTemplate(() =>
                {
                    var nombresLabel = new Label
                    {
                        TextColor = Color.Violet,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    };
                    nombresLabel.SetBinding(Label.TextProperty, "Nombres");

                    var apellidosLabel = new Label
                    {
                        TextColor = Color.Violet,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    };
                    apellidosLabel.SetBinding(Label.TextProperty, "Apellidos");

                    var edadLabel = new Label
                    {
                        TextColor = Color.Pink,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                    };
                    edadLabel.SetBinding(Label.TextProperty, "Edad");

                    return new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Padding = new Thickness(10),
                        Children = { nombresLabel, apellidosLabel, edadLabel }
                    };
                })
            };

            Content = collectionView;
        }
    }
}
