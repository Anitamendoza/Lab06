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
                Nombres = "Juan",
                Apellidos = "Pérez",
                Edad = 20
            });
            groupA.Add(new Estudiante
            {
                Nombres = "María",
                Apellidos = "González",
                Edad = 22
            });
            groupA.Add(new Estudiante
            {
                Nombres = "Carlos",
                Apellidos = "Martínez",
                Edad = 19
            });

            // Agregar cuatro alumnos con nombres y apellidos diferentes a la Sección B
            groupB.Add(new Estudiante
            {
                Nombres = "Luis",
                Apellidos = "Ramírez",
                Edad = 21
            });
            groupB.Add(new Estudiante
            {
                Nombres = "Ana",
                Apellidos = "Sánchez",
                Edad = 23
            });
            groupB.Add(new Estudiante
            {
                Nombres = "Pedro",
                Apellidos = "López",
                Edad = 20
            });
            groupB.Add(new Estudiante
            {
                Nombres = "Sofía",
                Apellidos = "Fernández",
                Edad = 24
            });

            // Agregar cinco alumnos con nombres y apellidos diferentes a la Sección C
            groupC.Add(new Estudiante
            {
                Nombres = "Eduardo",
                Apellidos = "Díaz",
                Edad = 22
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Laura",
                Apellidos = "Torres",
                Edad = 23
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Roberto",
                Apellidos = "Hernández",
                Edad = 19
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Isabel",
                Apellidos = "Pérez",
                Edad = 21
            });
            groupC.Add(new Estudiante
            {
                Nombres = "Miguel",
                Apellidos = "Gómez",
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
                        TextColor = Color.Black
                    };
                    label.SetBinding(Label.TextProperty, "Nombre");
                    return new StackLayout
                    {
                        BackgroundColor = Color.LightGray,
                        Padding = new Thickness(10),
                        Children = { label }
                    };
                }),
                ItemTemplate = new DataTemplate(() =>
                {
                    var nombresLabel = new Label
                    {
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    };
                    nombresLabel.SetBinding(Label.TextProperty, "Nombres");

                    var apellidosLabel = new Label
                    {
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    };
                    apellidosLabel.SetBinding(Label.TextProperty, "Apellidos");

                    var edadLabel = new Label
                    {
                        TextColor = Color.Red,
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
