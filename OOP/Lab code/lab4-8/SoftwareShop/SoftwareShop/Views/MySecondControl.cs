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
    ///     <MyNamespace:MySecondControl/>
    ///
    /// </summary>
    public class MySecondControl : Control
    {
        static MySecondControl() =>
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(MySecondControl),
                new FrameworkPropertyMetadata(typeof(MySecondControl)));

        // Text DP (length 1–10), коэрсим >10 → substr(0,10)
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text), typeof(string), typeof(MySecondControl),
                new FrameworkPropertyMetadata("", OnTextChanged, CoerceText),
                ValidateText);

        private static bool ValidateText(object v)
        {
            var s = v as string;
            return s != null && s.Length <= 10;  // разрешаем и 0…10
        }

        private static object CoerceText(DependencyObject d, object baseValue)
        {
            var s = baseValue as string ?? "";
            return s.Length > 10 ? s.Substring(0, 10) : s;
        }

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        // 3) RoutedEvents: Tunneling и Bubbling
        public static readonly RoutedEvent TunnelingEvent =
            EventManager.RegisterRoutedEvent(
                nameof(Tunneling), RoutingStrategy.Tunnel,
                typeof(RoutedEventHandler), typeof(MySecondControl));
        public static readonly RoutedEvent BubblingEvent =
            EventManager.RegisterRoutedEvent(
                nameof(Bubbling), RoutingStrategy.Bubble,
                typeof(RoutedEventHandler), typeof(MySecondControl));

        public event RoutedEventHandler Tunneling
        {
            add => AddHandler(TunnelingEvent, value);
            remove => RemoveHandler(TunnelingEvent, value);
        }
        public event RoutedEventHandler Bubbling
        {
            add => AddHandler(BubblingEvent, value);
            remove => RemoveHandler(BubblingEvent, value);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var rect = GetTemplateChild("PART_Border") as FrameworkElement;
            if (rect != null)
            {
                // Tunnel  
                rect.AddHandler(Mouse.PreviewMouseDownEvent,
                    new MouseButtonEventHandler((s, e) =>
                        RaiseEvent(new RoutedEventArgs(TunnelingEvent, this))), true);
                // Bubble
                rect.MouseLeftButtonUp += (s, e) =>
                    RaiseEvent(new RoutedEventArgs(BubblingEvent, this));
            }
        }
    }
}
