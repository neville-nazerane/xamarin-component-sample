using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemComponent : ContentView
    {

        public static readonly BindableProperty ItemProperty
            = BindableProperty.Create(
                        nameof(Item), typeof(Item), typeof(ItemComponent), null,
                        defaultBindingMode: BindingMode.TwoWay,
                        propertyChanged: ItemPropertyChanged);
        private readonly ItemComponentViewModel vm;

        static void ItemPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = (ItemComponent)bindable;
            view.Item = (Item)newValue;
        }

        public Item Item
        {
            get => (Item)GetValue(ItemProperty);
            set
            {
                SetValue(ItemProperty, value);
                if (vm != null) vm.Data = value;
            }
        }

        public ItemComponent()
        {
            InitializeComponent();
            vm = new ItemComponentViewModel();
            BindingContext = vm;
        }
    }
}