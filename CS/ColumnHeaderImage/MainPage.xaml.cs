﻿using System.Windows.Controls;

namespace ColumnHeaderImage {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }
    }
}
