using System;
using System.Collections.ObjectModel;
using System.Windows;
using ProductManagement.Framework;
using ProductManagement.Models;
using ProductManagement.Repositories;
using ProductManagement.Views;

namespace ProductManagement.ViewModels
{
    public class ProductListViewModel : BaseViewModel
    {
        private readonly IProductRepository _productRepository;
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                RaisePropertyChanged(nameof(Products));
            }
        }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                RaisePropertyChanged(nameof(SelectedProduct));
            }
        }
        public DelegateCommand AddCommand { get; private set; }

        public DelegateCommand EditCommand { get; private set; }

        public DelegateCommand DeleteCommand { get; private set; }

        public DelegateCommand RefreshCommand { get; private set; }

        public ProductListViewModel(IProductRepository repository)
        {
            _productRepository = repository;
            InitializeCommands();
            Products = new ObservableCollection<Product>(_productRepository.GetProducts());
        }


        private void InitializeCommands()
        {
            AddCommand = new DelegateCommand(o => this.OnAddCommandExecute());
            EditCommand = new DelegateCommand(o => this.OnEditCommandExecute());
            DeleteCommand = new DelegateCommand(o => this.OnDeleteCommandExecute());
            RefreshCommand = new DelegateCommand(o => this.RefreshProducts());
        }

        private void RefreshProducts()
        {
            MessageBox.Show(nameof(RefreshProducts));
        }

        private void OnAddCommandExecute()
        {
            var productDetailView = new ProductDetailView();
            productDetailView.ShowDialog();
        }

        private void OnEditCommandExecute()
        {
            if (SelectedProduct != null)
            {
                //MessageBox.Show(SelectedProduct.Name);
                var productDetailView = new ProductDetailView();
                productDetailView.ShowDialog();
            }
        }

        private void OnDeleteCommandExecute()
        {
            if (SelectedProduct != null)
            {
                MessageBox.Show(SelectedProduct.Name);
            }
        }

    }
}