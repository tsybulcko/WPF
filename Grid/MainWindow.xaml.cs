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
using System.ComponentModel;

namespace Grid
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		public MainWindow()
		{
			DataContext = this;
			InitializeComponent();
		}
		public event PropertyChangedEventHandler PropertyChanged;
		string boundText;
		public string BoundText
		{
			get => boundText;
			set 
			{  
				boundText = value;
				OnPropertyChanged();
			}
		}
		void OnPropertyChanged()
		{
			PropertyChanged.Invoke(this, new PropertyChangedEventArgs("BoundText"));
			//PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
			// ? (Null-conditional operator) - ипользуется при доступе к полям объекта или элементам массива.
			// obj?.member - если (obj == null), оператор '?' вернет 'null', в противном случае вернет значение поля 'member'.

			//htps://lwarn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
		}
	}
}
