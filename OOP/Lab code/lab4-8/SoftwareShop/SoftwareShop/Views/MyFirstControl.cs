using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoftwareShop.Views
{
    /// <summary>
    /// Выполните шаги 1a или 1b, а затем 2, чтобы использовать этот пользовательский элемент управления в файле XAML.
    ///
    /// Шаг 1a. Использование пользовательского элемента управления в файле XAML, существующем в текущем проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SoftwareShop.Views"
    ///
    ///
    /// Шаг 1б. Использование пользовательского элемента управления в файле XAML, существующем в другом проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:SoftwareShop.Views;assembly=SoftwareShop.Views"
    ///
    /// Потребуется также добавить ссылку из проекта, в котором находится файл XAML,
    /// на данный проект и пересобрать во избежание ошибок компиляции:
    ///
    ///     Щелкните правой кнопкой мыши нужный проект в обозревателе решений и выберите
    ///     "Добавить ссылку"->"Проекты"->[Поиск и выбор проекта]
    ///
    ///
    /// Шаг 2)
    /// Теперь можно использовать элемент управления в файле XAML.
    ///
    ///     <MyNamespace:MyFirstControl/>
    ///
    /// </summary>
    public class MyFirstControl : Control
    {
        // 1) Регистрация DP с валидацией и коэрсингом:
        //    - ValidateValueCallback проверяет 0 ≤ value ≤ 100
        //    - CoerceValueCallback обрезает значение к 50, если > 50
        public static readonly DependencyProperty IntValueProperty;

        // 2) Direct‑событие
        public static readonly RoutedEvent DirectEvent =
            EventManager.RegisterRoutedEvent(
                nameof(Direct),
                RoutingStrategy.Direct,
                typeof(RoutedEventHandler),
                typeof(MyFirstControl));

        static MyFirstControl()
        {
            // Связываем шаблон из Generic.xaml
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(MyFirstControl),
                new FrameworkPropertyMetadata(typeof(MyFirstControl)));

            // Задаём метаданные для IntValueProperty сразу с коэрсингом
            var meta = new FrameworkPropertyMetadata(
                /* defaultValue: */ 0,
                /* propertyChangedCallback: */ null,
                /* coerceValueCallback: */ CoerceIntValue);

            IntValueProperty = DependencyProperty.Register(
                nameof(IntValue),
                typeof(int),
                typeof(MyFirstControl),
                meta,
                ValidateIntValue);
        }

        // ValidateValueCallback
        private static bool ValidateIntValue(object value) =>
            value is int i && i >= 0 && i <= 100;

        // CoerceValueCallback
        private static object CoerceIntValue(DependencyObject d, object baseValue)
        {
            int v = (int)baseValue;
            return v > 50 ? 50 : v;
        }

        public int IntValue
        {
            get => (int)GetValue(IntValueProperty);
            set => SetValue(IntValueProperty, value);
        }

        // Обёртка для события
        public event RoutedEventHandler Direct
        {
            add => AddHandler(DirectEvent, value);
            remove => RemoveHandler(DirectEvent, value);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            // Ищем named-часть шаблона и вешаем генерацию DirectEvent по клику
            if (GetTemplateChild("PART_Border") is FrameworkElement fe)
            {
                fe.MouseLeftButtonDown += (s, e) =>
                {
                    RaiseEvent(new RoutedEventArgs(DirectEvent, this));
                };
            }
        }
    }
}
