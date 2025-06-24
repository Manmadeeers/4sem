using System.Windows;
using System.Windows.Controls;

namespace SoftwareShop.Views
{
    
    public class MyFirstControl : Control
    {
      
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
