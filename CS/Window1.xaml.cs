using System.Windows;
using System.Collections;
using DevExpress.Xpf.Grid;
// ...

namespace WpfApplication1 {

	public partial class Window1 : Window {
		public Window1() {
			InitializeComponent();

			ArrayList list = new ArrayList();
			list.Add(new Point() { X = 1, Y = 11});
			list.Add(new Point() { X = 2, Y = 12});
			list.Add(new Point() { X = 3, Y = 13});
			gridControl1.ItemsSource = list;
		}

		private void button3_Click(object sender, RoutedEventArgs e) {
            gridControl1.ExpandAllGroups();
		}
		private void button4_Click(object sender, RoutedEventArgs e) {
            gridControl1.CollapseAllGroups();
		}
	}
}
