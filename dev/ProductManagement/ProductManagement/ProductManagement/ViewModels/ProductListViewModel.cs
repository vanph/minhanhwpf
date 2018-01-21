using System;
using System.Collections.ObjectModel;
using System.Windows;
using ProductManagement.Framework;
using ProductManagement.Models;
using ProductManagement.Repositories;

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
            
        }

        private void OnAddCommandExecute()
        {
            
        }

        private void OnEditCommandExecute()
        {
        }

        private void OnDeleteCommandExecute()
        {
           
        }
        
    }
}